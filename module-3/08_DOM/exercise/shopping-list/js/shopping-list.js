// add pageTitle

  const pageTitle = 'My Shopping List';
  const groceries = ['item1', 'item2', 'item3', 'item4', 'item5', 'item6', 'item7', 'item8', 'item9', 'item10'];
// add groceries

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() 
{
  let title = document.getElementById('title');

  title.innerText = pageTitle;

}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() 
{
  
  for(let i = 0; i < groceries.length; i++)
  {
    let newItem = document.createElement('li');
    newItem.innerText = groceries[i];

    let list = document.getElementById('groceries');
    list.insertAdjacentElement('beforeend', newItem);
  }

}


/**
 * This function will be called when the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 */
function markCompleted() 
{
  
  for(let i = 0; i < groceries.length; i++)
  {
    let fullList = document.getElementById('groceries');

    let listItems = fullList.children;

    let listItemsArray = Array.from(fullList.children);

    listItemsArray[i].classList.add("completed");

  }
}

setPageTitle();

displayGroceries();

// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});
