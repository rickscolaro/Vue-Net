<template>
  <div class="container" id="app">
    <div class="nav-scroller py-1 mb-2">
      <nav class="nav d-flex justify-content-between">
        <a class="p-2 text-muted" href="https://vuejs.org/">Vue</a>
        <a class="p-2 text-muted" href="https://methodinformatica.com.br/">Method</a>
      </nav>
    </div>



    <Clientes msg="Bem Vindo Clientes " />

  </div>

</template>

<script>

import Clientes from './components/Clientes.vue'

export default {
  name: 'App',
  components: {
    Clientes,

  }
}
</script>

<style>
</style>
