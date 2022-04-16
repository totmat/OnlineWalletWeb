<template>
  <h1>adatok</h1>
<div class="container">
<div class="row ">
    <div class="col-xs-2">
        <div class="box">
            <form>
                <div class="login">
                    <label>Név</label><br>
                    <input type="text" >
                    <br>
                    <label >Felhasznaló neve</label>
                    <input type="text">
                    <br>
                    <label >jelszó</label>
                    <br>
                    <input type="text" >
                    <br>
                    <label>email</label>
                    <br>
                    <input type="text" >
                </div>
            </form>
        </div>
    </div>
  
</div>
     
 </div>
 <div class="container">
  <div class="row">
    <div class="col-md-4">
      <div class="card card-1" v-for="a in adatok" :key="a.id">
        <h3>{{a.nev}}</h3>
      </div>
    </div>
    <div class="col-md-4">
      <div class="card card-2" v-for="a in adatok" :key="a.id">
        <h3>{{a.username}}</h3>
      
      </div>
    </div>
    <div class="col-md-4">
      <div class="card card-3"  v-for="a in adatok" :key="a.id">
        <h3>{{a.email}}</h3>
        
      </div>
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
    }*/
    deletefelhasznalo(nev)
    /*{
        console.log(nev)
        axios.delete("http://localhost:5000/api/felhasznalo/torles/"+this.nev)
        .then(response => console.log(response))
        .catch((error) => console.log(error))
    }*/
    {
        console.log(nev)
    }

}
}
</script>

<style>

.container {
  display: flex;
  gap: 10px;
  gap: 10px 20px; /* row-gap column gap */
  row-gap: 10px;
  column-gap: 20px;
}
.card-body{
    background-color:aliceblue;
   /* background-image: url("../assets/person_icon.png");*/
    min-width: 500px;
    height: 500px;
    text-align: right;
}
.card
{
    display: flex;
    
}
.login{  
        width: 400px;  
        overflow: hidden; 
        margin: 10px 10px 10px 20px;  
        padding: 20px;  
        background: #919fbd;  
        border-radius: 15px ;
        border: solid 5px #4975d3;

          
}  
.btn 
{
    
    width:300px;
    background-color: #1a4fc2;
}

body{
  font-family: 'Nunito', sans-serif;
  padding: 50px;
}
.card{
    border-radius: 4px;
    background: #fff;
    box-shadow: 0 6px 10px rgba(0,0,0,.08), 0 0 6px rgba(0,0,0,.05);
      transition: .3s transform cubic-bezier(.155,1.105,.295,1.12),.3s box-shadow,.3s -webkit-transform cubic-bezier(.155,1.105,.295,1.12);
  padding: 14px 80px 18px 36px;
  cursor: pointer;
}

.card:hover{
     transform: scale(1.5);
  box-shadow: 0 10px 20px rgba(0,0,0,.12), 0 4px 8px rgba(0,0,0,.06);
}

.card h3{
  font-weight: 600;
}

.card img{
  position: absolute;
  top: 20px;
  right: 15px;
  max-height: 120px;
}

.card-1{
  background-image: url(https://ionicframework.com/img/getting-started/ionic-native-card.png);
      background-repeat: no-repeat;
    background-position: right;
    background-size: 80px;
}

.card-2{
   background-image: url(https://ionicframework.com/img/getting-started/components-card.png);
      background-repeat: no-repeat;
    background-position: right;
    background-size: 80px;
}

.card-3{
   background-image: url(https://ionicframework.com/img/getting-started/theming-card.png);
      background-repeat: no-repeat;
    background-position: right;
    background-size: 80px;
}

@media(max-width: 990px){
  .card{
    margin: 20px;
  }
} 
</style>