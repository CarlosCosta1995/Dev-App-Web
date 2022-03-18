<template>
  <div id="app">
    <nav-bar  v-if="$route.meta.navBar == true">

    </nav-bar>

    <router-view/>
    
    <footer-bar  v-if="$route.meta.footerBar == true">

    </footer-bar>
  </div>
</template>

<script>
import navBar from "@/components/navBar.vue";
import footerBar from "@/components/footerBar.vue";

export default {
  name: "App",
  components: {
    navBar,
    footerBar,
  },
}

</script>


<style scoped>

</style>
