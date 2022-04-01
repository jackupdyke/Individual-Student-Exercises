<template>
  <table class="table table-bordered table-hover">
    <thead>
      <tr>
        <td>Id</td>
        <td>Type</td>
        <td>Name</td>
        <td>Breed</td>
        <td>Image</td>
      </tr>
    </thead>
    <tbody>
      <tr v-for="pet in pets" v-bind:key="pet.Id">
        <td>{{ pet.id }}</td>
        <td>{{ pet.type }}</td>
        <td>{{ pet.name }}</td>
        <td>{{ pet.breed }}</td>
        <td><a v-bind:href="pet.image">{{ pet.image }} </a></td>
      </tr>
    </tbody>
  </table>
</template>

<script>
export default {
  name: "PetView",
  computed: {
    pets() {
      return this.$store.state.pets;
    },
  },
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