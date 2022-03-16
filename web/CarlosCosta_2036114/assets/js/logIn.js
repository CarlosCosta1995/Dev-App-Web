$('.message a').click(function(){
   $('form').animate({height: "toggle", opacity: "toggle"}, "slow");
});

function validateForm() {
   let x = document.forms["myForm"]["fname"].value;
   if (x == "") {
     alert("Name must be filled out");
     return false;
   }
 };
 
//  $(document).ready(function() {
//    $(".login-form acrylic").validate({
//      rules: {
//        email : {
//          required: true,
//          email: true
//        },
//        pw: {
//          required: true,
//          number: true,
//          min: 18
//        }
//      },
//      messages : {
//       email: {
//          required: "Please enter your email address!",
//          email: "The email should be in the format: abc@domain.tld"
//        },
//        pw: {
//          required: "Please enter your password!",
//          number: "Please enter your age as a numerical value",
//          min: "You must be at least 18 years old"
//        }
//      }
//    });
//  });
