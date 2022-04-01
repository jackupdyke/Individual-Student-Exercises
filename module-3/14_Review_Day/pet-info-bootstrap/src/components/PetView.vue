<template>
  <table class="table table-bordered table-hover">

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