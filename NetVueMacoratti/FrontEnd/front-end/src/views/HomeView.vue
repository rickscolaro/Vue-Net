<template>
  <div class="container ">
    <img alt="Vue logo" src="../assets/MethodLogo.png" class="img">
    <HelloWorld msg="Bem vindo"/>
  </div>
</template>

<script>

import HelloWorld from '@/components/HelloWorld.vue'

export default {
  name: 'HomeView',
  components: {
    HelloWorld
  }
}
</script>
<style>
.img{
  width: 800px;
}
</style>
