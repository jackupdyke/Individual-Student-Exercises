<template>
  <div>
      <button 
      id="show-form-button"
      href="#"
      v-if="showForm === false" 
      v-on:click.prevent="showForm = true" 
      >
        New Book Form
      </button>

    <form class="new-book-form" v-on:submit.prevent="addNewBook" v-if="showForm === true">
      <div >
        <label for="title">Title: </label>
        <input class="title-input" id="title" type="text" v-model="newBook.title" />
      </div>
      <div >
        <label for="author">Author: </label>
        <input class="author-input" id="author" type="text" v-model="newBook.author" />
      </div>
      <div >
        <label for="isbn">ISBN: </label>
        <input class="isbn-input" id="isbn" type="number" v-model="newBook.isbn" />
      </div>
      <input type="submit" value="Save" />
      <input type="button" value="Cancel" v-on:click.prevent="resetForm" />
    </form>
  </div>
</template>

<script>
export default {
  name: "new-book-form",
  data() {
    return {
      showForm: false,
      newBook: {
        title: "",
        author: "",
        read: false,
        isbn: null,
      },
    };
  },
  methods: {
    addNewBook() {
      this.$store.commit("ADD_BOOK", this.newBook);
      this.resetForm();
    },
    resetForm() {
      this.showForm = false;
      this.newBook = {
        title: "",
        author: "",
        read: false,
        isbn: null,
      };
    },
  },
};
</script>

<style>
</style>