/*Sweet and Salty Game Interactive*/

   /*Create Title Element*/
   let title1 = document.createElement('h1');
   let title2 = document.createElement('h4');
   let title3 = document.createElement('h4');
   /*add element to the body*/
   document.body.appendChild(title1);
   document.body.appendChild(title2);
   document.body.appendChild(title3);

   title1.innerHTML = 'Welcome to the SweetnSaltyInteractive Game';
   title2.innerHTML = 'You will be prompted to choose a starting number.';
   title3.innerHTML = 'Then you will be prompted to choose ending number that is at least 200 apart from the starting number you have chosen';
   //title2.innerHTML = 'Then you will be prompted to choose ending number that is at least 200 apart from the starting number you have chosen'

   /*create the input element*/
   let inputElem = document.createElement('input');
   /*add the element to the body*/
   document.body.appendChild(inputElem);

   /*Create a submit button*/
   let submitTodo = document.createElement('button');
   /*add the element to the body*/
   document.body.appendChild(submitTodo);
   submitTodo.innerText = "enter a number";

   /*Create to do list*/
   let GameProgression1 = document.createElement('ul');
   /*add element to the body*/
   document.body.appendChild(GameProgression1);

   let GameProgression2 = document.createElement('ul');
   /*add element to the body*/
   document.body.appendChild(GameProgression2);

   //GameProgression.innerHTML = "<li> Starting number you have entered is: </li>";
   //GameProgression.innerHTML += "<li> Ending number you have entered is: </li>";
   //.innerHTML += "<li> this is my third ordered list</li>";

   let myul1 = document.querySelector('ul');
   myul1.classList.add('ulclass');

   /*create an event listener*/
   submitTodo.addEventListener('click', (e)=>{
   let newTodo1 = inputElem.value;
   let myli1 = document.createElement('li');
   myli1.innerText = `${newTodo1}`;
   GameProgression1.innerHTML = `<li> Starting number you have entered is: ${newTodo1} </li>`;
   inputElem.value = '';
   inputElem.focus();

    submitTodo.addEventListener('click', (e)=>{
    let newTodo1 = inputElem.value;
    let myli1 = document.createElement('li');
    myli1.innerText = `${newTodo1}`;
    GameProgression1.innerHTML = `<li> Ending number you have entered is: ${newTodo1} </li>`;
    inputElem.value = '';
    inputElem.focus();
 });


});


  

/*create an event listener*/



 
 
