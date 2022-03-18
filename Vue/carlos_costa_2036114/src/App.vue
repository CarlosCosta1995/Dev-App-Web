<template>
  <div id="app">
    <nav-bar>

    </nav-bar>

    <router-view/>
    
    <footer-bar>

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
