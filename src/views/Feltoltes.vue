<template>
  <form @submit.prevent="kuldes" >
                <div class="adatfelvetel">
                    <label>Név</label>
                    <input type="text" name="nev" v-model="nev" >
                    <br>
                    <label >Felhasznaló neve</label>
                   
                    <input type="text" name="username" v-model="username" >
                    <br>
                    <label >jelszó</label>
                   
                    <input type="text" name="password" v-model="password">
                    <br>
                    <label>email</label>
                    
                    <input type="text" name="email" v-model="email">
                    <br>

                    <input type="submit" value="Jelentkezés" />
                </div>
            </form>
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
    }
}
</script>

<style>
.adatfelvetel{  
        width: 460px; 
        margin: 10px 10px 10px 100px;  
        padding: 20px;  
        background-color: green;  
        border-radius: 15px ;
        border: solid 5px #4975d3;  
        background-image: url('../assets/creditcardbackground.png');      
}  


</style>