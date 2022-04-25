<template>
  <h1>Bankkártya adatok</h1>

<div class="container">
  <div class="row text-center">
    <div class="col-md-3 card-container">
      <div class="card card-flip">
        <div class="front card-block">
          <h4 class="card-title">Kártyák számai: <br></h4>
          <h6 class="card-subtitle text-muted"><img src="../assets/creditcard_icon.png" height="250px"></h6>
        </div>
        <div class="back card-block"  v-for="a in adatok" :key="a.id">
          <div class="card-body col-sm-6 card-1">
            <div class="card">
              <h3> 
                Kártyák számai: {{a.cardNumber}}
              </h3> 
            </div>       
          </div>
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
        <div class="back card-block" v-for="a in adatok" :key="a.id">
          <div class="card-body col-sm-6 card-1">
            <div class="card">
              <h3 >Kártya biztonsági kódja: {{a.securityCode}} </h3>
              <div class="card"><h3>Lejárati dátuma : {{a.date}}</h3></div>
            </div>
          </div>
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