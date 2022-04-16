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
<div class="container">
  <div class="row">
    <div class="col-md-4">
      <div class="card card-1">
        <h3>Ionic Native</h3>
        <p>A curated set of   ES5/ES6/TypeScript wrappers for plugins to easily add any native functionality to your Ionic apps.</p>
      </div>
    </div>
    <div class="col-md-4">
      <div class="card card-2">
        <h3>UI Components</h3>
        <p>Tabs, buttons, inputs, lists, cards, and more! A comprehensive library
          of mobile UI components, ready to go.</p>
      </div>
    </div>
    <div class="col-md-4">
      <div class="card card-3">
        <h3>Theming</h3>
        <p>Learn how to easily customize and modify your app’s design to fit your
          brand across all mobile platform styles.</p>
      </div>
    </div>
  </div>
</div>
<!-- Visit https://codepen.io/nicolaskadis/full/brQEOd/ for the latest, no js version! -->
<div class="container">
  <div class="row text-center">
    <div class="col-md-4 card-container">
      <div class="card card-flip">
        <div class="front card-block">
          <!-- To add FontAwesome Icons use Unicode characters and to set size use font-size instead of fa-*x because when calculating the height (see js), the size of the icon is not calculated if using classes -->
          <span class="card-img-top fa" style="font-size: 4em">&#xf118;</span>
          <h4 class="card-title">Front Title</h4>
          <h6 class="card-subtitle text-muted">Front Sub-title</h6>
          <p class="card-text">Front Text</p>
        </div>
        <div class="back card-block">
          <p>
            Some example text<br> to
            <br> increase
            <br> card
            <br> height
            <br> to
            <br> something
            <br> long
          </p>
          <a href="#" class="btn btn-outline-primary">Read More</a>
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
          <p>Some example short text</p>
          <a href="#" class="btn btn-outline-primary">Read More</a>
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
    <div class="col-md-4 card-container">
      <div class="card card-flip">
        <div class="front card-block">
          <span class="card-img-top fa" style="font-size: 4em">&#xf118;</span>
          <h4 class="card-title">Front Title</h4>
          <h6 class="card-subtitle text-muted">Front Sub-title</h6>
          <p class="card-text">Front Text</p>
        </div>
        <div class="back card-block">
          <p>
            Some example text<br> to
            <br> increase
            <br> card
            <br> height
            <br> to
            <br> something
            <br> long
          </p>
          <a href="#" class="btn btn-outline-primary">Read More</a>
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
          <p>Some example short text</p>
          <a href="#" class="btn btn-outline-primary">Read More</a>
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
     transform: scale(1.05);
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
/* for demo purposes */
body {
  background: grey;
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
  transition: all 0.5s ease-out;
  background: white;
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