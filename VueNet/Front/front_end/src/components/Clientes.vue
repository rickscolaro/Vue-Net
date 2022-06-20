
<template>
  <div>
    <div class="jumbotron p-3 p-md-5 text-white rounded bg-dark">
      <div class="col-md-6 px-0">
        <h1 class="display-4 font-italic">{{ msg }}</h1>
      </div>
    </div>


    <form class="mb-5">

      <div class="form-group">
        <label for="nome">Nome</label>
        <!-- Id escondido para manipulação-->
        <input type="hidden" id="clienteId" name="clienteId">
        <input type="text" class="form-control" v-model="cliente.nome" id="nome" name="nome"
          placeholder="Digite o seu nome">

      </div>

      <div class="form-group">
        <label for="telefone">Telefone</label>
        <input type="hidden" id="clienteId" name="clienteId">
        <input type="tel" class="form-control" v-model="cliente.telefone" id="telefone" name="telefone"
          placeholder="Digite o seu te-lefone">
      </div>

      <div class="form-group">
        <label for="endereco">Endereco</label>
        <input type="hidden" id="clienteId" name="clienteId">
        <input type="text" class="form-control" v-model="cliente.endereco" id="endereco" name="endereco"
          placeholder="Digite o seu endereço">
      </div>

      <button v-on:click="Salvar()" type="button" class="btn btn-primary">Enviar</button>

      <div style="color:red">
        {{ mensagem }}
      </div>

    </form>

    <table class="table">
      <thead>
        <tr>
          <th>Id</th>
          <th>Nome</th>
          <th>Telefone</th>
          <th>Endereço</th>
          <th></th>

          <!--Dar espaços na coluna-->
          <!-- <th colspan="2"> </th> -->

        </tr>
      </thead>
      <tbody>
        <tr v-for="cliente in clientes" v-bind:key="cliente.id">
          <td>{{ cliente.clienteId }}</td>
          <td>{{ cliente.nome }}</td>
          <td>{{ cliente.telefone }}</td>
          <td>{{ cliente.endereco }}</td>

          <!-- Botões -->
          <div>
            <td>
              <button class="btn btn-primary" v-on:click="EditarTela(cliente)">Editar</button>
            </td>
            <td>
              <button class="btn btn-danger" v-on:click="Excluir(cliente.clienteId)">Excluir</button>
            </td>
          </div>


        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>

import axios from "axios"

export default {
  name: "Clientes",
  props: {
    msg: String
  },
  data: () => {
    return {
      clientes: [],
      mensagem: "",
      //cliente: undefined
      cliente: { nome: "", telefone: "", endereco: "" }// Precisa para fazer o v-model


    }
  },
  methods: {
    // Método chamando lista recebe um escopo
    // lista: (scope) => {
    //   axios.get(`https://localhost:7097/clientes`).then((res) => {
    //     //console.log(res)
    //     scope.clientes = res.data
    //   })
    // },

    //Fazer a lista
    lista() {

      this.cliente = { nome: "", telefone: "", endereco: "" }// Toda vez que chamar a lista ja limpa o escopo

      axios.get(`https://localhost:7097/clientes`).then((res) => {
        //console.log(res)
        this.clientes = res.data
      })
    },


    Salvar() {
      // Se tiver no escopo um objeto chamado cliente
      // if (this.cliente) {
      //   this.Alterar()
      //   return // tem que dar um return se não continua e faz um Salvar()
      // }

      // Se o id estiver preenchido ai ira para o alterar
      if (this.cliente.clienteId) {
        this.Alterar()
        return // tem que dar um return se não continua e faz um Salvar()
      }

      // axios.post(`https://localhost:7097/clientes`, {
      //   nome: document.getElementById("nome").value,
      //   endereco: document.getElementById("endereco").value,
      //   telefone: document.getElementById("telefone").value
      // }).then(() => {

      //   this.lista()
      // })


      axios.post(`https://localhost:7097/clientes`, this.cliente).then(() => {

        this.lista()
      })

      console.log(`Salvando  ${nome.value}`)
    },

    Excluir(id) {

      // O confirm é nativo do java script
      if (confirm("Confirma a exclusão?")) {
        axios.delete(`https://localhost:7097/clientes/${id}`).then(() => {
          this.lista()
        })
      }

      console.log(`O cliente de ID:${id} foi excluído com sucesso!`)
      alert(`O cliente de ID:${id} foi excluído com sucesso!`)
    },

    // Mostra na tela para ficar na memorio do escopo
    EditarTela(cliente) {

      // document.getElementById("nome").value = cliente.nome
      // document.getElementById("telefone").value = cliente.telefone
      // document.getElementById("endereco").value = cliente.endereco
      // this.cliente = cliente// escopo

      this.cliente = cliente
    },

    // Atualização dos dados preenchido em memoria
    Alterar() {

      // this.cliente.nome = document.getElementById("nome").value
      // this.cliente.telefone = document.getElementById("telefone").value
      // this.cliente.endereco = document.getElementById("endereco").value


      axios.put(`https://localhost:7097/clientes/${this.cliente.clienteId}`, this.cliente).then(() => {

        this.lista()

        alert(`O cliente de  foi alterado com sucesso!`)

        // this.cliente = undefined // Limpando objeto do escopo(Limpando o escopo)
        // document.getElementById("nome").value = ""
        // document.getElementById("telefone").value = ""
        // document.getElementById("endereco").value = ""
      })


      //console.log(`Alterado com sucesso  o cliente: ${cliente.nome}`)
    }

  },
  created() {
    this.lista()
  }
}
</script>

<style scoped>
</style>