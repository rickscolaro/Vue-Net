import { createApp } from 'vue'
import App from './App.vue'

//Instalação VueRouter
import VueRouter from "vue-router"
import Home from "./components/Home.vue"
import Sobre from "./components/Sobre.vue"

//Vue.use(VueRouter)

// const routes = [
//     { path: "/", components: Home },
//     { path: "/clientes", components: Home },
//     { path: "/sobre", components: Sobre }
// ]

// const router = new VueRouter({
//     routes: routes
// })



createApp(App).mount('#app')
