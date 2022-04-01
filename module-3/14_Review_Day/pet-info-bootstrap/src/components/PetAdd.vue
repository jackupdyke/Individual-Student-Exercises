<template>
  <div class="container">
    <a
      href="#"
      class="btn btn-success"
      v-if="!isFormShown"
      v-on:click.prevent="isFormShown = true"
      >Add Pet
    </a>

    <form v-if="isFormShown" v-on:submit.prevent="onSubmit">
      <div class="form-group">
        <label for="id">ID: </label>
        <input
        required
          type="number"
          id="id"
          name="id"
          class="form-control"
          v-model="newPet.id"
        />
      </div>
<div class="form-group">
        <label for="id">Type </label>
        <input
        required
          type="text"
          id="id"
          name="id"
          class="form-control"
          v-model="newPet.type"
        />
      </div>

      <div class="form-group">
        <label for="id">Name </label>
        <input
        required
          type="text"
          id="id"
          name="id"
          class="form-control"
          v-model="newPet.name"
        />
      </div>

      <div class="form-group">
        <label for="id">Breed </label>
        <input
        required
          type="text"
          id="id"
          name="id"
          class="form-control"
          v-model="newPet.breed"
        />
      </div>

      <div class="form-group">
        <label for="id">Image </label>
        <input
        
          type="text"
          id="id"
          name="id"
          class="form-control"
          v-model="newPet.image"
        />
      </div>
      <input  type="submit" value="submit" class="btn btn-warning" />
      <input
        type="button"
        value="cancel"
        class="btn btn-success"
        v-on:click="resetForm"
      />
    </form>
  </div>
</template>

<script>
export default {
  name: "PetAdd",
  data() {
    return {
      isFormShown: false,
      newPet: {},
    };
  },

  methods: {
    onSubmit() {
      //console.log(this.newPet);
      this.$store.commit("ADD_PET", this.newPet)
      this.resetForm();
    },

    resetForm() {
      this.isFormShown = false;
      this.newPet = {}
    },
  },
};
</script>

<style>
form {
  width: 50%;
  margin: 20px;
}

label {
  text-align: left;
  display: block;
}

.btn {
  margin: 0 5px;
}
</style>