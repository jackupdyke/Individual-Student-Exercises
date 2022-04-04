<template>
  <div class="card" v-bind:class="book.read ? 'read' : '' ">
    <h2 class="book-title">{{ book.title }}</h2>

    <img
      v-if="book.isbn"
      v-bind:src="
        'http://covers.openlibrary.org/b/isbn/' + book.isbn + '-M.jpg'
      "
    />

    <h3 class="book-author">{{ book.author }}</h3>
    <button
      class="mark-read"
      type="button"
      v-on:click="updateReadStatus(book)"
      v-if="!book.read"
    >
      Mark as read
    </button>
    <button
      class="mark-unread"
      type="button"
      v-on:click="updateReadStatus(book)"
      v-if="book.read"
    >
      Mark as unread
    </button>
  </div>
</template>

<script>

export default {
  name: "book-card",
  props: ["book"],
  methods: {
    updateReadStatus(book) {
      if (!book.read) {
        this.$store.commit("MARK_READ", book);
      } else {
        this.$store.commit("MARK_UNREAD", book);
      }
    },
  },
};
</script>

<style>
.card {
  border: 2px solid black;
  border-radius: 10px;
  width: 250px;
  height: 550px;
  margin: 20px;
}

.card.read {
  background-color: lightgray;
}

.card .book-title {
  font-size: 1.5rem;
}

.card .book-author {
  font-size: 1rem;
}
</style>