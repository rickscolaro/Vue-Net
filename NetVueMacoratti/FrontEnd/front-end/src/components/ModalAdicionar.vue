<template>
    


    <!------------------Modal------------->

    <!-- Button trigger modal -->
    <button type="button" class="btn btn-success" data-bs-toggle="modal" data-bs-target="#exampleModal">
        Adicionar Alunos
    </button>

    <!-- Modal -->
    <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">


                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Cadastrar Aluno</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>

                <div class="modal-body">

                    <form class="form-group text-left">

                        <div class="form-group">
                            <label for="nome">Nome</label>
                            <!-- Id escondido para manipulação-->
                            <input type="hidden" id="alunoId" name="alunoId">
                            <input type="text" class="form-control" v-model="aluno.nome" id="nome" name="nome"
                                placeholder="Digite o seu nome">

                        </div>

                        <div class="form-group">
                            <label for="idade">Idade</label>
                            <input type="hidden" id="alunoId" name="alunoId">
                            <input type="tel" class="form-control" v-model="aluno.idade" id="idade" name="idade"
                                placeholder="Digite a sua idade">
                        </div>

                        <div class="form-group">
                            <label for="email">Email</label>
                            <input type="hidden" id="alunoId" name="alunoId">
                            <input type="text" class="form-control" v-model="aluno.email" id="email" name="email"
                                placeholder="Digite o seu emaail">
                        </div>
                    </form>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Fechar</button>
                    <button v-on:click="postModal()" type="button" class="btn btn-success">Enviar</button>
                </div>

            </div>
        </div>
    </div>




</template>

<script>

import Alunos from "../views/Alunos.vue"

export default {
    name: "ModalAdicioanar",
    data() {
        return {
            alunos: [],
            aluno: { nome: "", idade: "", email: "" }// Para poder preencher os campos e fazer v-model
        }
    },

    methods: {

        getModal() {
            Alunos.methods.getAlunos()
        },

        postModal() {

            Alunos.methods.postAluno(this.aluno)
            //Alunos.methods.teste()
           
        },

        
    },
    created() {
        this.getModal()
    },
}
</script>

<style>
</style>