<template>
  <h1>Bankkártya adatok</h1>
  

<div class="container">
  <div class="row text-center">
    <div class="col-md-3 card-container">
      <div class="card card-flip">
        <div class="front card-block">
          <!-- To add FontAwesome Icons use Unicode characters and to set size use font-size instead of fa-*x because when calculating the height (see js), the size of the icon is not calculated if using classes -->
          <span class="card-img-top fa" style="font-size: 4em">
              </span>
         
          <h4 class="card-title">Kártyák számai: <br>
          
          </h4>
           
          <h6 class="card-subtitle text-muted"><img src="../assets/creditcard_icon.png" height="250px"></h6>
          
        </div>
        <div class="back card-block"  v-for="a in adatok" :key="a.cardNumber">
            <h3>{{a.cardNumber}}</h3>
            <h3>{{a.date}}</h3>
            <h3>{{a.securityCode}}</h3>
            
         
        </div>
      </div>
    </div>
    <div class="col-md-3 card-container">
      <div class="card card-flip">
        <div class="front card-block">
          <h4 class="card-title">Kártya további adatai
              
          </h4>
          <h6 class="card-subtitle text-muted"><img src="../assets/creditcardback_icon.png" height="250px" alt=""></h6>
          <p class="card-text"></p>
        </div>
        <div class="back card-block" v-for="a in adatok" :key="a.cardNumber">
            <h3 >Kártya biztonsági kódja </h3>
            <h3>{{a.securityCode}}</h3>
           


  
         
        </div>
      </div>
    </div>
 <div class="col-md-4 card-container">
      <div class="card card-flip">
        <div class="front card-block">
          <h4 class="card-title">További adatok hozzáadása</h4>
          <h6 class="card-subtitle text-muted">Front Sub-title</h6>
          <p class="card-text"><img src="../assets/plus_icon.png" height="250px" alt=""></p>
        </div>
        <div class="back card-block">
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
        
        </div>
      </div>
    </div>

    <div class="col-md-4 card-container">
      <div class="card card-flip">
        <div class="front card-block">
          <span class="card-img-top fa" style="font-size: 4em">&#xf118;</span>
          <h4 class="card-title">Front Title</h4>
          <h6 class="card-subtitle text-muted">Front Sub-title</h6>
          <p class="card-text">Front Text</p>
        </div>
        <div class="back card-block">
          <p>Some example text</p>
          <a href="#" class="btn btn-outline-primary">Read More</a>
        </div>
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
        adatok:[]
    }
},
created()
{
     axios.get("http://localhost:5000/api/bankkartyak/")
        .then(response => {this.adatok = response.data})
        .catch((error) =>console.log(error))
}


}
</script>

<style>
 
.login{  
        width: 400px;  
        overflow: hidden; 
        margin: 10px 10px 10px 20px;  
        padding: 20px;  
        background: #919fbd;  
        border-radius: 15px ;
        border: solid 5px #4975d3;

          
}  
 
/* for demo purposes */
body {
  background: rgb(245, 243, 243);
}

.card-block .btn-outline-primary {
  width: 100%;
  border-top-left-radius: 0;
  border-top-right-radius: 0;
  bottom: 0;
  left: 0;
  position: absolute;
}

.card {
  margin: 20px 0;
}

/* Flip Cards CSS */
.card-container {
  perspective: 700px;
}
.card-flip {
  position: relative;
  width: 100%;
  transform-style: preserve-3d;
  height: auto;
  transition: all 0.9s ease-out;
  background: rgb(143, 175, 228);
  border: none;
}

.card-flip div {
  backface-visibility: hidden;
  transform-style: preserve-3d;
  height: 100%;
  width: 100%;
  border: none;
}

.card-flip .front {
  position: relative;
  z-index: 1;
}

.card-flip .back {
  position: relative;
  z-index: 0;
  transform: rotateY(-180deg);
}

.card-container:hover .card-flip {
  transform: rotateY(180deg);
}
</style>