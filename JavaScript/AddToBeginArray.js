var myArray = ['a', 'b', 'c', 'd', 'e'];
console.log('Current entries before operations: ', JSON.stringify(myArray));
myArray = AddToBeginning(myArray, 'aa');
console.log('Entries after add to beginning function called: ', JSON.stringify(myArray));
myArray = AddToEnd(myArray, 'zz');
console.log('Entries after add to end function called: ', JSON.stringify(myArray));

function AddToBeginning(targetArray, thingToAdd)
{
    targetArray.unshift(thingToAdd);
    return targetArray;
}

function AddToEnd(targetArray, thingToAdd)
{
    targetArray.push(thingToAdd);
    return targetArray;
}