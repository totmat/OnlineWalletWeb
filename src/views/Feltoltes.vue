<template>
 
            <form @submit.prevent="kuldes" class="form-container card-adatfelvetel">
                <div class="adatfelvetel">
                  <h3 >Felhasználó adatai</h3>
                   <div class="form-group">
                    <label>Név</label>
                    <input type="text" name="nev"  v-model="nev" >
                    <label >Felhasznaló neve</label>
                    <input type="text" name="username" v-model="username" >
                    <label >jelszó</label>
                    <input type="text" name="password" v-model="password">
                    <label>email</label>
                    <input type="text" name="email" v-model="email">
                    <input type="submit" value="Felhasználó feltöltése" />
                    <b-alert show dismissible fade>Dismissible Alert!</b-alert>

    <b-alert
      variant="danger"
      dismissible
      fade
      :show="showDismissibleAlert"
      @dismissed="showDismissibleAlert=false"
    >
      Dismissible Alert!
    </b-alert>
                   </div>
                </div>
            </form >        
            
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

            ,
            cardNumber:'',
            date:'',
            securityCode:'',
            firsName:'',
            lastName:''


            
        }
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
      },
      
    }
       
}
</script>

<style>

/*.adatfelvetel{  
        width: 460px; 
        margin: 10px 10px 10px 100px;  
        padding: 20px;  
        background-color: green;  
        border-radius: 15px ;
        border: solid 5px #4975d3;  
        background-image: url('../assets/creditcardbackground.png');      
}  */

.card-adatfelvetel
{
   min-width: 25rem;
  display: flex;
  float: left;
  margin-left: 10%;
}

.creditcard-1
{
  min-width: 21rem;
  min-height: 13rem;
  display: flex;
  float: left;
  background-image: url('../assets/creditcardbackground.png');
   float:right;
   margin-right: 15%;
}

.form-container {
    max-width: 800px;
    padding: 20px;
    color: #1b1a1a;
    text-align: center;
    background-color: #cac7c7;
   
}

label {
    padding-bottom: 5px;
    font-size: 13px;
}

input {
    margin-top: 3px;
    padding: 15px;
    font-size: 16px;
    width: 100%;
    border-radius: 3px;
    border: 1px solid #dcdcdc;
}


</style>