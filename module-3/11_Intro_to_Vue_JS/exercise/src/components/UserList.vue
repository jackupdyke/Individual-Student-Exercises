<template>
  <table id="tblUsers">
    <thead>
      <tr>
        <th>First Name</th>
        <th>Last Name</th>
        <th>Username</th>
        <th>Email Address</th>
        <th>Status</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td>
          <input v-model="filter.firstName" type="text" id="firstNameFilter" />
        </td>
        <td>
          <input v-model="filter.lastName" type="text" id="lastNameFilter" />
        </td>
        <td>
          <input v-model="filter.username" type="text" id="usernameFilter" />
        </td>
        <td>
          <input v-model="filter.emailAddress" type="text" id="emailFilter" />
        </td>
        <td>
          <select v-model="filter.status" id="statusFilter">
            <option value="">Show All</option>
            <option value="Active">Active</option>
            <option value="Disabled">Disabled</option>
            <td><input v-model="filter.status" type="text" /></td>
          </select>
        </td>
      </tr>
      <!-- user listing goes here -->
      <tr
        v-for="user in filteredList"
        v-bind:key="user.emailAddress"
        v-bind:class="{ disabled: user.status === 'Disabled' }"
      >
        <td>{{ user.firstName }}</td>
        <td>{{ user.lastName }}</td>
        <td>{{ user.username }}</td>
        <td>{{ user.emailAddress }}</td>
        <td>{{ user.status }}</td>
      </tr>
    </tbody>
  </table>
</template>

<script>
export default {
  name: "user-list",
  data() {
    return {
      filter: {
        firstName: "",
        lastName: "",
        username: "",
        emailAddress: "",
        status: "",
      },
      users: [
        {
          firstName: "John",
          lastName: "Smith",
          username: "jsmith",
          emailAddress: "jsmith@gmail.com",
          status: "Active",
        },
        {
          firstName: "Anna",
          lastName: "Bell",
          username: "abell",
          emailAddress: "abell@yahoo.com",
          status: "Active",
        },
        {
          firstName: "George",
          lastName: "Best",
          username: "gbest",
          emailAddress: "gbest@gmail.com",
          status: "Disabled",
        },
        {
          firstName: "Ben",
          lastName: "Carter",
          username: "bcarter",
          emailAddress: "bcarter@gmail.com",
          status: "Active",
        },
        {
          firstName: "Katie",
          lastName: "Jackson",
          username: "kjackson",
          emailAddress: "kjackson@yahoo.com",
          status: "Active",
        },
        {
          firstName: "Mark",
          lastName: "Smith",
          username: "msmith",
          emailAddress: "msmith@foo.com",
          status: "Disabled",
        },
      ],
    };
  },
  computed: {
    filteredList() {
      return this.users.filter(
        (user) =>
          user.firstName.toLowerCase().includes(this.filter.firstName) &&
          user.lastName.toLowerCase().includes(this.filter.lastName) &&
          user.username.includes(this.filter.username) &&
          user.emailAddress.includes(this.filter.emailAddress) &&
          user.status.includes(this.filter.status)
      );
    },
  },
};
</script>

<style scoped>
table {
  margin-top: 20px;
  font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, Oxygen,
    Ubuntu, Cantarell, "Open Sans", "Helvetica Neue", sans-serif;
}
th {
  text-transform: uppercase;
}
td {
  padding: 10px;
}
tr.disabled {
  color: red;
}
input,
select {
  font-size: 16px;
}
</style>