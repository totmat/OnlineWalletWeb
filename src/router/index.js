import { createRouter, createWebHistory } from 'vue-router'
import Home from '../views/Home.vue'


const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/igazolvanyok',
    name: 'Igazolvanyok',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/Igazolvanyok.vue')
  },
  {
  path:'/felhasznalok',
  name:'felhasznalok',
  component: () => import('../views/Felhasznalok.vue')
  },
  { 
    path:'/bankkartyak',
    name:'bankkartyak',
    component: () => import('../views/Bankkartyak.vue')
  },
  {
  path:'/feltoltes',
  name:'feltoltes',
  component: ()=> import('../views/Feltoltes.vue')
  },
  {
    path:'/igazolvanyfeltoltes',
    name:'igazolvanyfeltoltes',
    component: ()=> import('../views/IgazolvanyokFeltoltes.vue')

  },
  {
    path:'/bankkartyafeltoltes',
    name:'bankkartyafeltoltes',
    component: ()=> import('../views/BankkartyaFeltoltes.vue')
  }
    
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
