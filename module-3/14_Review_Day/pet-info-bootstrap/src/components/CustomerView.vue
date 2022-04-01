<template>
   <table class="table table-bordered table-hover">
    <thead>
      <tr>
        <td>Id</td>
        <td>Name</td>
        <td>Phone</td>
        <td>Email</td>
      </tr>
    </thead>
    <tbody>
      <tr v-for="customer in customers" v-bind:key="customer.id">
        <td>{{ customer.id }}</td>
        <td>{{ customer.name }}</td>
        <td>{{ customer.phone }}</td>
        <td>{{ customer.email }}</td>
      </tr>
    </tbody>
  </table>
</template>

<script>
export default {
   name: 'CustomerView',
  computed: {
    customers(){
      return this.$store.state.customers;
    }
  }
};
</script>

<style scoped>
table,
th,
td {
  border: 1px solid black;
}

table {
  width: 50%;
  margin: 20px;
}
</style>