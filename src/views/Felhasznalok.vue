<template>
  <h1>adatok</h1>
  <div class="card" v-for="a in adatok" :key="a.id">
      <div class="card-body">
          <h2>{{a.nev}}</h2>
      </div>
  </div>
</template>

<script>
import axios from "axios"
export default {
    data(){
        return{
            adatok: []
        }
    },
    created()
    {
        axios.get("http://localhost:5000/api/Felhasznalok")
        .then(response => {this.adatok = response.data})
        .catch((error) =>console.log(error))
    }
}
</script>

<style>

</style>