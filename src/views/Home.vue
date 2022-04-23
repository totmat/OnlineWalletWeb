<template>
<div class="body">
  <div class="container">
    <h2>Welcome to the OnlineWallet website</h2>
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
}
</script>
  <style>
.body
{
   background-image: url('../assets/creditcardicon.gif');
  min-height: 25rem;
}
</style>