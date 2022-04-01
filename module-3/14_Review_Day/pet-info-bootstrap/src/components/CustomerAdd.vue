<template>
  <div class="container">


  </div>
</template>

<script>
export default {
  name: 'CustomerAdd',
  data() {
    return {
     
    };
  },

  methods: {
    onSubmit() {
    
    },

    resetForm() {
      this.newCustomer = {};
      this.isFormShown = false;
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

.btn{
  margin: 0 5px;
}
</style>