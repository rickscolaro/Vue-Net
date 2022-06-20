<template>



    <div class="container">

        <div class="Alunos">
            <br>
            <h3>Cadastro de Alunos</h3>
            <header class="mb-4">
                <img class="imag " src="../assets/aluna.png" alt="">
                <ModalAdicioanar />
            </header>
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Nome</th>
                        <th>Email</th>
                        <th>Idade</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="item in alunos" v-bind:key="item.alunoId">
                        <td>{{ item.alunoId }}</td>
                        <td>{{ item.nome }}</td>
                        <td>{{ item.email }}</td>
                        <td>{{ item.idade }}</td>
                        <td>
                            <button class="btn btn-primary mr-3" v>Editar</button>
                            <button class="btn btn-danger" v-on:click="deleteAluno(item.alunoId)">Excluir</button>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>

    </div>


</template>

<script>

import ModalAdicioanar from "../components/ModalAdicionar.vue"

import Axios from "axios"

export default {
    name: "Alunos",
    components: {
        ModalAdicioanar
    },
    data() {
        return {
            alunos: [],
            aluno: { nome: "", idade: "", email: "" }// Para poder preencher os campos e fazer v-model
        }
    },
    methods: {
        getAlunos() {
            Axios
                .get("https://localhost:7097/alunos")
                .then((res) => {
                    console.log(res.data)
                    this.alunos = res.data
                })
                .catch((error) => {
                    console.log(error)

                })
        },


        // Passo o x para pegar no componente ModalAdicionar
        postAluno(x) {

            // Axios.post(`https://localhost:7097/alunos`, { nome: "favio", idade: 25, email: "xxxx" }).then(() => {

            //     this.getAlunos()
            //     console.log("Usuario cadastrado com sucesso")

            // })
            //     .catch((error) => {
            //         console.log("Erro ao cadastrar usuário: " + error)
            //         console.log()
            //     })

            Axios.post(`https://localhost:7097/alunos`, x).then(() => {


                console.log("Usuario cadastrado com sucesso")

            })
                .catch((error) => {
                    console.log("Erro ao cadastrar usuário: " + error)
                    console.log()
                })

        },

        deleteAluno(id) {

            //O confirm é nativo do java script
            if (confirm("Confirma a exclusão?")) {
                Axios.delete(`https://localhost:7097/alunos/${id}`).then(() => {
                    this.getAlunos()
                })
            }

            console.log(`O cliente de ID:${id} foi excluído com sucesso!`)
            alert(`O cliente de ID:${id} foi excluído com sucesso!`)
        },

        teste() {
            console.log("testando")
        }
    },
    created() {
        this.getAlunos()
    },
}

// Axios
//     .get("https://localhost:7097/alunos")
//     .then((res)=>{
//         console.log(res.data)
//     })
//     .catch((error)=>{
//         console.log(error)
//     })

</script>

<style>
.imag {
    width: 50px;
}
</style>