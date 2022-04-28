<template>


<form @submit.prevent="igazolvanykuldes" class="form-container card-adatfelvetel ">
                  <div class="adatfelvetel">
                   <h3>Töltse fel az igazolvány adataival !</h3>
                   <div class="form-group">
                   
                    
                    <label>Dokumentum azonosító</label>

              <input type="text" name="documentId" v-model="documentId">
              <label>Teljes neve</label>
              <input type="text" name="fullname" v-model="fullname">
              <label>Neme</label>
              <input type="text" name="gender" v-model="gender">
              <label>Születés éve</label>
              <input type="text" name="year" v-model="year">
              <label>Születés hónapja</label>
              <input type="text" name="month" v-model="month">
              <label>Születés napja</label>
              <input type="text" name="day" v-model="day">
              <input type="submit" name="Igazolvány hozzádasa">
                
                </div>
        </div>
            </form>
</template>

<script>
import axios from 'axios'
export default {
    data()
    {
        return
        {   
            
            documentId: ''
            fullname: ''
            gender: ''
            year: ''
            month: ''
            day: ''
           
        };
    },
    methods:{
        igazolvanykuldes()
        {
            let url = "http://localhost:5000/api/postigazolvanyok"
            let adat = {documentId: this.documentId,
            fullname: this.fullname,
            gender: this.gender ,
            year: this.year ,
            month: this.month ,
            day: this.day
            }
            if(this.documentId != '' && this.fullname != '' && this.gender != '' && this.year != '' && this.month != '' && this.day != '')
            {
                axios.post(url, adat)
                .then((response) =>{console.log(response)})
                .catch((error) => console.log(error))
            }
        }
    }

}
</script>

<style>
.igazolvanyfelvetel
{
    min-width: 25rem;
    display: flex;
     float: left;
    margin-left: 10%;
    
}
.form-container 
{
    max-width: 800px;
    padding: 20px;
    color: #1b1a1a;
    text-align: center;
    background-color: #cac7c7;
}
input
{
    margin-top: 3px;
    padding:15px;
    font-size: 16px;
    width: 100%;
    border-radius: 3px;
    border: 1px solid #dcdcdc;
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