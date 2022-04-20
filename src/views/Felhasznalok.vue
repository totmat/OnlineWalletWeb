<template>
  <h1>adatok</h1>
<div class="container">
  <div class="col-lg-6">
        <div class="box">
            <form @submit.prevent="kuldes">
                <div class="login">
                    <label>ID</label><br>
                    <input type="text" name="ID" v-model="id">
                    <label>Név</label><br>
                    <input type="text" name="nev" v-model="nev" >
                    <br>
                    <label >Felhasznaló neve</label>
                    <input type="text" name="username" v-model="username">
                    <br>
                    <label >jelszó</label>
                    <br>
                    <input type="text" name="password" v-model="password">
                    <br>
                    <label>email</label>
                    <br>
                    <input type="text" name="email" v-model="email">
                </div>
                 <input type="submit" value="Jelentkezés" />
            </form>
             <table>
      <tr>
        <td>{{nev}}</td>
        <td>{{username}}</td>
        <td>{{password}}</td>
        <td>{{email}}</td>
      </tr>
    </table>
        </div>
    </div>
  

     
 </div>
 <div class="container">
  <div class="row">
    <div class="col-md-4">
      <div class="card card-1" v-for="a in adatok" :key="a.id">
        <h3>{{a.fullname}}</h3>
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
        let adat = ''
        if(this.id != '' && this.nev != '' && this.username != '' && this.email != '' && this.password != '')
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

.container {

  gap: 10px;
  gap: 10px 20px; /* row-gap column gap */
  row-gap: 10px;
  column-gap: 20px;
  text-align: center;

}
.box
{
    text-align: center;
}
.card-body{
    background-color:aliceblue;
   /* background-image: url("../assets/person_icon.png");*/
    min-width: 500px;
    height: 500px;
    text-align: right;
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