window.onload = load;
//asigns various events to start application properly
function load(){
  document.getElementById('cattoggle').onclick = categoryToggle;
  document.getElementById('login').onclick = loginToggle;
  document.getElementById('logo').onclick = onLogoClick;
  //get collection of all times icons and add events to hide on click belove
  var timesCollection = document.getElementsByClassName("fa-times-circle-o");
  //event triggers when clicked on times icon and hides its parent
  for(var i = 0; i < timesCollection.length;i++ ){
  timesCollection[i].onclick = closeElement;
  }

  var menuItems = document.getElementsByClassName('nav-icons');
  for(var j = 0; j < menuItems.length; j++){
    menuItems[j].onclick = toggleArrows;
  }
  //preforms custom actions on windows resize
  window.addEventListener("resize",windowSizeChanged);
}

//on categories click while windows size below 450 shows dropdown menu or hides it.
function categoryToggle(){
    var bar = this.getElementsByClassName('fa')[0];
    if(bar.classList.toggle('fa-bars')){
      bar.classList.remove('fa-times');
      document.getElementById("drop-toggle").style.display="none";
    }
    else {
      bar.classList.add('fa-times');
      document.getElementById("drop-toggle").style.display="flex";
    }
  }

//shows/hides login/register menu on click
 function loginToggle() {
   var loginForm = document.getElementsByClassName('login-form')[0];
   var status = window.getComputedStyle(loginForm);
   if(status.display === "none"){
     document.getElementsByClassName('login-form')[0].style.display = "flex";
   }
   else {
     document.getElementsByClassName('login-form')[0].style.display = "none";
   }
 }

//closes parent form which contines "fa-times" class when clicked on times icon
 function closeElement() {
   this.parentElement.style.display = "none";
 }

//function is triggered on windows size change and performs different actions
function windowSizeChanged(){
  var width = document.documentElement.clientWidth;
  if(width > 450){
    //hide toggle categories for small screen devices
    var btn = document.getElementById('cattoggle');
    var bar = btn.getElementsByClassName("fa")[0];
    bar.classList.add('fa-bars');
    bar.classList.remove('fa-times');
    document.getElementById("drop-toggle").style.display="none";
  }
}

function toggleArrows(){
  var itemsWithArrows = document.getElementsByClassName('arrows-navbar');
  for(var i = 0; i < itemsWithArrows.length; i++){
    itemsWithArrows[i].classList.remove('arrows-navbar');
  }
  if(this.classList.contains("arrows")){
     this.classList.add('arrows-navbar');
     }
}

function onLogoClick(){
  toggleArrows();
}
