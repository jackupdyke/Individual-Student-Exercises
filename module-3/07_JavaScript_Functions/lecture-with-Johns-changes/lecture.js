
//const names = ["Primrose", "Gabriel", "Penny"]
//console.log(names)


// FOREACH


//name.forEach((arg1) => test1(arg1))

//names.forEach(arg1 => test1(arg1))

//names.forEach(
// function test2(name){
// console.log("from test2: " + name);
//})

//names.forEach(
//  function (name){
//  console.log("from test3: " + name);
//})

//names.forEach(
//  (name) => {
//  console.log("from test4: " + name);
//})


//names.forEach(
//  (name) => console.log("from test5: " + name))


//names.forEach(name => console.log("from test6: " + name))

function test1(name) {
  console.log("from test1: " + name);
}




//const names = ["Primrose", "Gabriel", "Penny"]
//console.log(names)


//FIND

// const searchTerm = "xyz"

// const result = names.find((name) => name.includes(searchTerm))

// if (result){
//   console.log("Found name")
// }else{
//   console.log ("did not find name")
// }


// const resultIndex = names.findIndex((name) => name.includes(searchTerm))
// console.log(resultIndex)



//FILTER

// const names = ["Primrose", "Gabriel", "Penny"]
// console.log(names)

// const searchTerm = "enn"
// const result = names.filter(item => item.includes(searchTerm))
// console.log(result)


//MAP 

// const names = ["Primrose", "Gabriel", "Penny"]
// console.log(names)

// const result = names.map( item => "Cat: " + item)
// console.log(result)

//REDUCE

// const nums =[3,1,4,1,5,9,2,6]
// console.log (nums);

// const result = nums.reduce((total,num) => total + num) 
// const average = result /nums.length
// console.log (result)
// console.log(average)

/**
 * All named functions will have the function keyword and
 * a name followed by parentheses.
 * 
 * @returns {number} 1
 */
function returnOne() {
  return 1;
}

/**
 * Functions can also take parameters. These are just variables that are filled
 * in by whoever is calling the function.
 *
 * Also, we don't *have* to return anything from the actual function.
 *
 * @param {any} value the value to print to the console
 */
function printToConsole(value) {
  console.log(value);
}

/**
 * Write a function called multiplyTogether that multiplies two numbers together. But 
 * what happens if we don't pass a value in? What happens if the value is not a number?
 *
 * @param {number} firstParameter the first parameter to multiply
 * @param {number} secondParameter the second parameter to multiply
 */

/**
 * This version makes sure that no parameters are ever missing. If
 * someone calls this function without parameters, we default the
 * values to 0. However, it is impossible in JavaScript to prevent
 * someone from calling this function with data that is not a number.
 * Call this function multiplyNoUndefined
 *
 * @param {number} [firstParameter=0] the first parameter to multiply
 * @param {number} [secondParameter=0] the second parameter to multiply
 */



/**
 * Functions can return earlier before the end of the function. This could be useful
 * in circumstances where you may not need to perform additional instructions or have to
 * handle a particular situation.
 * In this example, if the firstParameter is equal to 0, we return secondParameter times 2.
 * Observe what's printed to the console in both situations.
 * 
 * @param {number} firstParameter the first parameter
 * @param {number} secondParameter the second parameter
 */
function returnBeforeEnd(firstParameter, secondParameter) {
  console.log("This will always fire.");

  if (firstParameter == 0) {
    console.log("Returning secondParameter times two.");
    return secondParameter * 2;
  }

  //this only runs if firstParameter is NOT 0
  console.log("Returning firstParameter + secondParameter.");
  return firstParameter + secondParameter;
}

/**
 * Scope is defined as where a variable is available to be used.
 *
 * If a variable is declare inside of a block, it will only exist in
 * that block and any block underneath it. Once the block that the
 * variable was defined in ends, the variable disappears.
 */
function scopeTest() {
  // This variable will always be in scope in this function
  let inScopeInScopeTest = true;

  {
    // this variable lives inside this block and doesn't
    // exist outside of the block
    let scopedToBlock = inScopeInScopeTest;
  }

  // scopedToBlock doesn't exist here so an error will be thrown
  if (inScopeInScopeTest && scopedToBlock) {
    console.log("This won't print!");
  }
}

function createSentenceFromUser(name, age, listOfQuirks = [], separator = ', ') {
  let description = `${name} is currently ${age} years old. Their quirks are: `;
  return description + listOfQuirks.join(separator);
}

/**
 * Takes an array and, using the power of anonymous functions, generates
 * their sum.
 *
 * @param {number[]} numbersToSum numbers to add up
 * @returns {number} sum of all the numbers
 */
function sumAllNumbers(numbersToSum) {
  return numbersToSum.reduce();
}

/**
 * Takes an array and returns a new array of only numbers that are
 * multiples of 3
 *
 * @param {number[]} numbersToFilter numbers to filter through
 * @returns {number[]} a new array with only those numbers that are
 *   multiples of 3
 */
function allDivisibleByThree(numbersToFilter) {

  const result = numbersToFilter.filter(item => {
    return item % 3 === 0
  })

  return result;
}
