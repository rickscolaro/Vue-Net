<template>

  <div>

    <section class="jumbotron text-center">
      <div class="container">
        <img id="img" src="../assets/images/02.png" alt="">

        <h1 class="jumbotron-heading mt-5 mb-5" >Bem Vindo!</h1>
        <p>
          <!-- Da para fazer pelo  href="#"-->
          <a href="/clientes" class="btn btn-success my-2">Cadastrar Clientes</a>

        </p>
      </div>
    </section>

  </div>
</template>

<script>
export default {
  name: "Home"

}
</script>

<style>
#img{
  width: 600px;
}
</style>