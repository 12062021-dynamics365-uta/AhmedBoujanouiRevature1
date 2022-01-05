
//print out all the numbers to the console 1-1000
for (var i = 1; i <= 1000; i++) {
    console.log(i);
   }

   /*the code below will print out all the numbers from 1 to 1000
   in groups of 20 numbers per line with one space between the numbers
   */
   console.log('\n 20 numbers at a time per line');
(function() {
  var x = '',
      i = 1
  while (i <= 1000) {
    x += i
    x += i%20 ? ' ' : '\n'
    i++
  }


  console.log(x)
})()

/*this will print sweet if multiple of 3, salty if multiple 0f 5 and sweetnsalty if multiple 
of both 3 and 5*/

var multipleofthreecounter = 0;
var multipleoffivecounter = 0;
var multipleofboththreeandfivecounter = 0;
for (var i =1; i <= 1000; i++)
{
    if(i%3==0 && i%5 !=0)
    {
        console.log('sweet')
        multipleofthreecounter = multipleofthreecounter +1
    }
    else if (i%5==0 && i%3 != 0)
    {
        console.log('salty')
        multipleoffivecounter = multipleoffivecounter + 1
    }
    else if(i%3==0 && i%5==0)
    {
        console.log('SweetnSalty')
        multipleofboththreeandfivecounter = multipleofboththreeandfivecounter + 1
    }
    else
    {
        console.log(i)
    }


};

/*this will count how many numbers are multiple of 3 and how many multiple of 5
and how many are multiple of both 3 and 5 */
console.log('multiple of 3 and 5:',multipleofboththreeandfivecounter)
console.log('multiple of five:',multipleoffivecounter)
console.log('multiple of three:',multipleofthreecounter)
