<template>
  <h1>Bankkártya adatok</h1>

<div class="container">
  <div class="row">
    <div class=" col-6 card-container">
      <div class="card card-flip">
        <div class="front card-block">
          <h4 class="card-title">Kártyák számai: <br></h4>
          <h6 class="card-subtitle text-muted"><img src="../assets/creditcard_icon.png" height="250px"></h6>
        </div>
        <div class="back card-block"  >
          <div class="card-body card-1">
            <div class="card" v-for="a in adatok" :key="a.cardNumber">
              <h3> 
                Kártyák számai: {{a.cardNumber}}
              </h3> 
            </div>       
          </div>
        </div>
      </div>
    </div>
    <div class=" col-6 card-container">
      <div class="card card-flip">
        <div class="front card-block">
          <h4 class="card-title">Kártya további adatai </h4>
          <h6 class="card-subtitle text-muted"><img src="../assets/creditcardback_icon.png" height="250px" alt=""></h6>
          <p class="card-text"></p>
        </div>
        <div class="back card-block ">
          <div class="card-body">
            <div class="card" v-for="a in adatok" :key="a.id">
              <h3 >Kártya biztonsági kódja: {{a.securityCode}} </h3>
              <div class="card"   ><h3>Lejárati dátuma : {{a.date}}</h3></div>
            </div>
          </div>
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
        adatok:[],
        
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
 
.card-block .btn-outline-primary {
  width: 30px;
  border-top-left-radius: 3px;
  border-top-right-radius: 3px;
  
}

.card {
  margin: 10px 0;
  max-width: 800px;
}

/* Flip Cards CSS */
.card-container {
  perspective: 1000px;
}
.card-flip {
  position: relative;
  width: 100%;
  transform-style: preserve-3d;
  height: auto;
  transition: all 0.9s ease-out;
  background: rgb(120, 212, 219);
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