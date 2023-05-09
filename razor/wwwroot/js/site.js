// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function addstudent()
{
    console.log(" add stuent ");


    fetch('/api/student/create', 
    { 
        method: 'post', 
        headers:{ 'Content-Type': 'application/json' },
        body: JSON.stringify({ name: "moha", age: 234 })
    }
    
    )
    .then( resp => resp.json() )
    .then( data =>{ console.log( 'data : ', data ) } )
    .catch( err =>{ console.error( ' ERROR : ', err  ) } );
}