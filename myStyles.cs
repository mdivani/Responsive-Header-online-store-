* {
  -webkit-box-sizing:border-box;
  -moz-box-sizing:border-box;
  box-sizing:border-box;
  padding:0;
  margin:0;
}

a {
  text-decoration:none;
  text-align:center;
}

body {
  background-color:#e0ecff;
}

label {
  height:30px;
  line-height:30px;
  margin-left:5px;
  margin-right:5px;
}

label.small-text {
  font-size:13px;
  font-weight:400;
  width:100%;
  text-align:center;
}

.container {
  width:100%;
  height:100vh;
  margin:auto;
  padding:20px;
}

.navbar {
  display:flex;
  justify-content: flex-end;
  align-items:center;
  flex-flow:row wrap;
  background-color:#032302;
  height:auto;
  min-width:300px;
  border:0px 1px 0px 1px double #fffff;
  padding:4px 0px 4px 0px;
  margin:0;
  box-shadow:1px 0px 1px 1px #000;
}

.dropdown {
  position:relative;
  display:flex;
  justify-content:center;
  align-items:center;
  flex-flow:column wrap;
  background-color:inherit;
  padding:5px;
}

.dropdown-elements {
  position:absolute;
  top:50px;
  left:0;
  display:none;
  justify-content:center;
  align-items:center;
  flex-direction:column;
  background-color:inherit;
  width:100%;
  min-width:300px;
  z-index:2;
  opacity:0.9;
}

a.drop {
  width:100%;
  border-bottom:0.5px groove #eee;
  margin:auto;
}

a.hoverable:hover {
  background-color:#097504;
}

.arrows-navbar {
  position: relative;
}

.arrows-navbar::before {
  position:absolute;
  top:42px;
  left:0;
  right:0;
  margin-left:auto;
  margin-right:auto;
  content:" ";
  width:0;
  height:0;
  border:6.5px solid;
  border-color:#e0ecff transparent transparent #e0ecff;
  transform:rotate(45deg);
}

.arrows {

}

.arrow-login::before {
  content:" ";
  position:absolute;
  width:0;
  height:0;
  border:6.5px solid;
  top:-5px;
  right:20px;
  border-color:#fff transparent transparent #fff;
  z-index:101;
  transform:rotate(45deg);
  opacity:0.9;
  display:none;
}

.dropdown:hover div.dropdown-elements {
  display:flex;
}

.btn-toggle {
  height:40px;
  width:40px;
  background-color:inherit;
  padding:1px;
  color:#fff;
  border:none;
  cursor:pointer;
  order:1;
}

.btn-toggle:focus {
  outline:none;
}

.toggle-elements {
  height:280px;
  width:240px;
  margin-bottom:3px;
  border:2px solid #fff;
}

.nav-logo {
  font-family:'Brush Script MT', cursive;
  font-weight:600;
  font-size:25px;
  text-align:center;
  height:40px;
  line-height:40px;
  color:#d15e0c;
  text-shadow:0.5px 1px #000;
  cursor:default;
  margin-left:5px;
  margin-right: auto;
  cursor:pointer;
}

.nav-logo:hover {
  color:#7c2c04;
}

.nav-toggle {
  display:flex;
  justify-content:flex-end;
  max-width:200px;
  height:auto;
  margin-right:5px;
  background-color:inherit;
}

.nav-icons {
  height:40px;
  text-align:center;
  line-height:40px;
  font-family:'Andale Mono', AndaleMono, monospace;
  color:#fff;
  font-weight:500;
  font-size:20px;
  cursor:pointer;
  padding-right:5px;
  margin-right:5px;
  text-shadow:0.5px 0.5px #000;
}

.nav-icons:hover {
  color:#ccc;
}

.nav-user-info {
  display:flex;
  justify-content:space-between;
  align-items:center;
  order:0;
}

.login-form {
  display:none;
  flex-direction:column;
  align-items:center;
  justify-content:center;
  position:absolute;
  left:0;
  top:0;
  right:0;
  opacity:0.9;
  height:100vh;
  min-width:300px;
  background-color:#fff;
  font-size:17px;
  z-index:100;
}

.times-right {
  position:absolute;
  top:5px;
  right:5px;
  color:#111;
}

input.login {
  height:30px;
  margin:10px;
  border-radius:5px;
  background-color:#d6d45e;
  padding:10px;
}

button.submit-btn, input.submit-btn {
  margin-left:auto;
  margin-right:5px;
  padding:5px;
  width:80px;
  border:none;
  background-color:#032302;
  color:#fff;
  border-radius:5px;
}

.row {
  display:flex;
  justify-content:flex-start;
  align-items:center;
  color:#222;
  margin-top:10px;
  margin-bottom:5px;
}

.fa-user:hover div.login-form{
  display:flex;
}

.nav-search {
  display:flex;
  justify-content:center;
  align-items:center;
  margin:auto;
  width:100%;
  height:40px;
  background-color:inherit;
}

input.search {
  margin-right:5px;
  margin-left:5px;
  height:25px;
  padding:8px;
  line-height:25px;
  width:90%;
  border-radius:10px;
  font-family:'Helvetica Neue', Helvetica, Arial, sans-serif;
  font-weight:600;
  color:#032302;
}

input.search:focus {
  outline:none;
}

.nav-manu {
  display:none;
  background-color:inherit;
}

.hidden-icons {
  display:none;
}

.nomargin {
  margin:0 !important;
}

.col-xs-1 {width: 8.33%;}
.col-xs-2 {width: 16.66%;}
.col-xs-3 {width: 25%;}
.col-xs-4 {width: 33.33%;}
.col-xs-5 {width: 41.66%;}
.col-xs-6 {width: 50%;}
.col-xs-7 {width: 58.33%;}
.col-xs-8 {width: 66.66%;}
.col-xs-9 {width: 75%;}
.col-xs-10 {width: 83.33%;}
.col-xs-11 {width: 91.66%;}
.col-xs-12 {width: 100%;}

@media only screen and (min-width:450px) {
  .nav-search {
    order:1;
    width:60%;
  }

  .nav-user-info {
    order:2;
  }

  .btn-toggle {
    display:none;
  }

  .nav-manu {
    display:flex;
    justify-content:space-around;
    align-items:center;
    height:40px;
    order:3;
    width:100%;
  }

  .dropdown-elements {
    min-width:100px;
    display:none;
  }

  .login-form {
    top:100px;
    margin:auto;
    width:420px;
    height:300px;
    margin-left:auto;
    margin-right:auto;
    border-radius:5px;
    box-shadow:2px 2px 4px 1px #000;
  }

  .arrows {
    position:relative;
  }

[class*="col-"] {
  width: 100%;
}

.col-ms-1 {width: 8.33%;}
.col-ms-2 {width: 16.66%;}
.col-ms-3 {width: 25%;}
.col-ms-4 {width: 33.33%;}
.col-ms-5 {width: 41.66%;}
.col-ms-6 {width: 50%;}
.col-ms-7 {width: 58.33%;}
.col-ms-8 {width: 66.66%;}
.col-ms-9 {width: 75%;}
.col-ms-10 {width: 83.33%;}
.col-ms-11 {width: 91.66%;}
.col-ms-12 {width: 100%;}
}

@media only screen and (min-width:770px) {
  .nav-search {
    order:1;
    width:40%;
  }
  .nav-manu {
    order:2;
    width:40%;
  }
  .nav-user-info {
    justify-content:space-around;
    order:3;
  }

.col-1 {width: 8.33%;}
.col-2 {width: 16.66%;}
.col-3 {width: 25%;}
.col-4 {width: 33.33%;}
.col-5 {width: 41.66%;}
.col-6 {width: 50%;}
.col-7 {width: 58.33%;}
.col-8 {width: 66.66%;}
.col-9 {width: 75%;}
.col-10 {width: 83.33%;}
.col-11 {width: 91.66%;}
.col-12 {width: 100%;}
}

@media only screen and (min-width:1080px) {

  .hidden-icons {
    display: inline;
  }

  .nav-user-info {
    width:90px;
  }

  .login-form {
    top:43px;
    margin-right:1px;
    margin-left:auto;
    max-width:280px;
    min-width:280px;
    height:400px;
  }

  .arrow-login::before {
    display:inline;
  }
}
