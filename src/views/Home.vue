<template>
    <div class="login">    
    <form id="login" method="get" action="login.php">    
        <label><b>Felhasználó neve     
        </b>    
        </label>    
        <input type="text" name="Uname" id="Uname" placeholder="Username">    
        <br><br>    
        <label><b>Jelszó     
        </b>    
        </label>    
        <input type="Password" name="Pass" id="Pass" placeholder="Password">    
        <br><br>    
        <input type="button" name="log" id="log" value="Log In Here">       
 
            
           
    </form>     
    </div>
<br>
  <h1>adatok</h1>
  <div class="card" v-for="a in adatok" :key="a.id">
      <div class="card-body">
          <h2>{{a.nev}}</h2>
      </div>
  </div>
</template>




<script>
// @ is an alias to /src
import HelloWorld from '@/components/HelloWorld.vue'
import axios from "axios"
export default {
  name: 'Home',
  components: {
    HelloWorld
  }
  ,data()
    {
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

<style scoped>
body  
{  
    margin: 0;  
    padding: 0;  
    background-color:#5195b4ba;  
    font-family: 'Arial';  
}  
.login{  
        width: 400px;  
        overflow: hidden;  
        margin: auto;  
        margin: 20 0 0 450px;  
        padding: 60px;  
        background: #23463f;  
        border-radius: 15px ;  
          
}  
h2{  
    text-align: center;  
    color: #277582;  
    padding: 20px;  
}  
label{  
    color: #a5d4cb;  
    font-size: 17px;  
}  
#Uname{  
    width: 300px;  
    height: 30px;  
    border: none;  
    border-radius: 3px;  
    padding-left: 8px; 
 
}  
#Pass{  
    width: 300px;  
    height: 30px;  
    border: none;  
    border-radius: 3px;  
    padding-left: 8px;  
      
}  
#log{  
    width: 300px;  
    height: 30px;  
    border: none;  
    border-radius: 17px;  
    padding-left: 7px;  
    color: rgb(53, 53, 82);  
  
  
}  

</style>