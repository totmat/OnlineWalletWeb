<template>
  <h1>Felhasználók adatai</h1>
<div class="container mt-12">
  <div class="col-lg-5">
        
    </div>
    
      <div class="row">
        <div class="card col-sm-5 " v-for="a in adatok" :key="a.id">
          <div class="card-body col-sm-12   ">
            <h3>{{a.fullname}}</h3>
            <h3>{{a.username}}</h3>
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
            id:'',
            nev:'',
            username:'',
            email:'',
            password:''

            
        }
    },
    created()
    {
      
        axios.get("http://localhost:5000/api/Felhasznalok")
        .then(response => {this.adatok = response.data})
        .catch((error) =>console.log(error))
    },
    methods:{
      kuldes()
      {
        let url = "http://localhost:5000/api/postfelhasznalok"
        let adat = {fullname: this.nev,email: this.email, username: this.username, password:this.password

        }
        if( this.nev != '' && this.username != '' && this.email != '' && this.password != '')
        {
          axios.post(url, adat)
          .then((resp) =>{console.log(resp)})
          .catch((error) => console.log(error))
        }
      }
        /*kuldes()
        {
            let url = ''
            let adat = ''
            if(this.nev != '' 
            && this.username != '' 
            && this.email != '' 
            && this.password != '' -1)
            {
                axios.post(url="http://localhost:5000/api/postfelhasznalok", adat).then(response => this.adat = this.adat);
                
            }else
            {
                alert('Kérem töltse ki az összes mezőt!')
            }
        },*/
    /*onPost(id)
    {
        console.log(id);
        axios.post("http://localhost:5000/api/FelhasznalokPost",id)
        .then(response =>this.id = response.data.id);
    }
    deletefelhasznalo(nev)*/
    /*{
        console.log(nev)
        axios.delete("http://localhost:5000/api/felhasznalo/torles/"+this.nev)
        .then(response => console.log(response))
        .catch((error) => console.log(error))
    }
    {
        console.log(nev)
    }*/

}
}
</script>

<style>
/*
.container {

  text-align: center;
  background-image: url('../assets/usercard.gif');

}
.box
{
    text-align: center;
}
.card-body{
    min-width: 100px;
    height: 200px;
    text-align: center;
    background-image: url('../assets/usercard.gif');
}

.adatfelvetel{  
        width: 360px;  
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
    margin: 10px;
    box-shadow: 0 6px 10px rgba(0,0,0,.08), 0 0 6px rgba(0,0,0,.05);
    transition: .3s transform cubic-bezier(.155,1.105,.295,1.12),.4s box-shadow,.4s -webkit-transform cubic-bezier(.155,1.105,.295,1.12);
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


@media(max-width: 990px){
  .card{
    margin: 20px;
  }
} */
</style>