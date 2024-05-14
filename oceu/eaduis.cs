// Using the 'Lorem' class to generate a list of words
var wordsList = lorem.GenerateWords(1);

// Ensuring the list is not empty to avoid a NullReferenceException
if (wordsList != null && wordsList.Any())
{
    // Taking the first word from the generated list
    string word = wordsList.FirstOrDefault();
    
    // The 'word' variable now contains the first generated word
    // Further processing can be done with 'word' as needed
}
else
{
    // Handle the case where no words were generated
    // This could involve logging an error, providing a default value, etc.
}
