$(document).ready(function(){
  $.ajax({
    url: "http://localhost:52488/api/Groups/GetGroups",
    method: "GET",
     success: function () {
      alert();
      }
                 });
    
});