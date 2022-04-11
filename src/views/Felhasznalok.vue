<template>
  <h1>adatok</h1>
  <div class="row">
      
  <div class="card col-lg-3 col-md-4" v-for="a in adatok" :key="a.id">
      <div class="card-body">
          <h2>{{a.nev}}</h2>
          <h3>{{a.email}}</h3>
        
          <button type="button" @click="deleteFelhasznalo(a.nev)" class="btn btn-primary">Törlés</button>
      </div>
  </div>
  </div>
</template>

<script>
import axios from "axios"
export default {
    data(){
        return{
            adatok: [],
            
        }
    },
    created()
    {
        axios.get("http://localhost:5000/api/Felhasznalok")
        .then(response => {this.adatok = response.data})
        .catch((error) =>console.log(error))
    },
    methods:{
    /*onPost(id)
    {
        console.log(id);
        axios.post("http://localhost:5000/api/FelhasznalokPost",id)
        .then(response =>this.id = response.data.id);
    }
    deletefelhasznalo(nev)
    {
        console.log(nev)
        axios.delete("http://localhost:5000/api/felhasznalo/torles/"+this.nev)
        .then(response => console.log(response))
        .catch((error) => console.log(error))
    }*/
}
}
</script>

<style>

</style>