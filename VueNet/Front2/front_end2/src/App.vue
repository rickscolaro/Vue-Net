<template>

  <nav class="navbar navbar-expand-lg navbar-dark bg-success nav-scroller py-1 mb-2">

    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#corNavbar02"
      aria-controls="corNavbar02" aria-expanded="false" aria-label="Alterna navegação">
      <span class="navbar-toggler-icon"></span>
    </button>

    <div class="container">
      <div class="collapse navbar-collapse" id="corNavbar02">
        <ul class="navbar-nav mr-auto nav-scroller py-1 mb-2 ">
          <li class="nav-item active">
            <a class="nav-link" href="/">Home <span class="sr-only">(Página atual)</span></a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="/sobre">Sobre</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="https://methodinformatica.com.br/">Method</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="https://vuejs.org/">Vue</a>
          </li>
        </ul>
      </div>
    </div>
  </nav>

  <div class="container ">
    <router-view />
  </div>

</template>
<script>



export default {
  name: 'App',
  components: {


  }
}

</script>

<style>
</style>
