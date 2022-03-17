<template>
  <!-- <nav>
    <router-link to="/">Home</router-link> |
    <router-link to="/about">LoginRegister</router-link> |
    <router-link to="/admin">Admin</router-link>
  </nav> -->
  <header-all></header-all>
  <router-view/>
  <footer-all></footer-all>
</template>

<style scoped>
@import "@/assets/css/style.css";
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

nav {
  padding: 30px;
}

nav a {
  font-weight: bold;
  color: #2c3e50;
}

nav a.router-link-exact-active {
  color: #42b983;
}
</style>

<script>
import HeaderAll from "@/components/HeaderAll.vue";

import 'bootstrap/dist/css/bootstrap.min.css'
import 'jquery/src/jquery.js'
import 'bootstrap/dist/js/bootstrap.min.js'
import FooterAll from './components/FooterAll.vue';

export default {
  name: "App",
  components: {
    HeaderAll,
    FooterAll
  },
};
</script>

