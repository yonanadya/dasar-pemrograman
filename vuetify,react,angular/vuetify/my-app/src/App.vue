<template>
  <v-app>
  <div id="app">
    <img src="https://unri.ac.id/wp-content/uploads/2021/03/logo-unri2-800x116.png" height="75" width="400">
    <web-toolbar></web-toolbar>
      <router-view/>
    <web-footer></web-footer>
  </div>
</v-app>
</template>

<script>
import WebFooter from './components/WebFooter.vue'
import WebToolbar from './components/WebToolbar.vue'

export default {
  name: 'App',
  components: {WebFooter,WebToolbar}
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
}
</style>