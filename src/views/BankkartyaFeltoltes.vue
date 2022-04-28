<template>

<form @submit.prevent="bankkartyakuldes" class="form-container card-adatfelvetel ">
                  <div class="adatfelvetel">
                  <h3 >Bankkártya adatai</h3>
                   <div class="form-group">
                    <label>Kártya száma</label>
                    <input type="text" name="cardNumber"  v-model="cardNumber" >
                    
                    <label >Születési ideje</label>
                     
                    <input type="text" name="date" v-model="date" >
                  
                    <label >Biztonsági kód</label>
                   
                    <input type="text" name="securityCode" v-model="securityCode">
                    <br>
                     <div class="form-group">
                    <label>Keresztnév</label>
                    <input type="text" name="firstName"  v-model="firstName" >
                    </div>
                     <div class="form-group">
                    <label>Vezetéknév</label>
                    <input type="text" name="lastName"  v-model="lastName" >
                    </div>

                    <input  type="submit" value="Bankkártya hozzáadás" />
                </div>
                </div>

            </form>
</template>

<script>
import axios from "axios"
export default {
data(){
    return{
            cardNumber:'',
            date:'',
            securityCode:'',
            firstName:'',
            lastName:''
    }
},

methods:
{
 bankkartyakuldes()
      {
        let url = "http://localhost:5000/api/postbankkartyak"
        let adat = {cardNumber: this.cardNumber,
        date: this.date,
        securityCode: this.securityCode,
        firstName: this.firstName, 
        lastName:this.lastName
        }
        if( this.cardNumber != '' && this.date != '' && this.securityCode != '' && this.firstName != '' && this.lastName != ''  ) 
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