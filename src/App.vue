<template>
  <div id="nav">
    <router-link to="/">Home</router-link> |
    <router-link to="/felhasznalok">Felhasznalok</router-link> |
    <router-link to="/bankkartyak">Bankártyák</router-link> |
    <router-link to="/igazolvanyok">Igazolványok</router-link>
  </div>
  <router-view/>
</template>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #435669;
}

#nav {
  padding: 30px;
  background-image: linear-gradient( rgb(120, 212, 219),rgb(224, 244, 252));
  font-size: 1.2rem;
}


#nav a {
  font-weight: bold;
  color: #2f3f4e;
}

#nav a.router-link-exact-active {
  color: #41108f;
}


</style>
