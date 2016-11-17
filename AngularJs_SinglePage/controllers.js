//forecastController
weatherApp.controller("forecastController",["$scope","$resource","cityService",function($scope,$resource,cityService){
   $scope.cityName = cityService.name;
    
    $scope.weatherAPI = $resource("http://api.openweathermap.org/data/2.5/forecast?q=" + $scope.cityName + ",SAC&mode=JSON&appid=5a0549aee2a30bfdfa64995d4ba90b3a",{callback:"JSON_CALLBACK"},{ get: {method: "JSONP"}});
   
    $scope.weatherResult = $scope.weatherAPI.get({        
    });
    
    console.log($scope.weatherResult )
    
    $scope.convertToFahrenheit = function(degK) {
        
        return Math.round((1.8 * (degK - 273)) + 32);
        
    }
    
    $scope.convertToCentigrade = function(degK){
        
        return Math.round (degK - 273.15);
    }
    
    $scope.convertToDate = function(dt) { 
      
        return new Date(dt * 1000);
        
    };
    
}]);

//homeController
weatherApp.controller("homeController",["$scope","$http","$resource","$location","cityService",function($scope,$http,$resource,$location,cityService){
    $scope.cityName = cityService.name;
    
    $scope.$watch('cityName',function(){
        cityService.name =  $scope.cityName;
        
    });
    
    $scope.submit = function(){
      $location.path("/forecast")  
        
    }
//    $scope.GroupAPI = $resource("http://localhost:52488/api/Groups/GetGroups",{callback:"JSON_CALLBACK"},{ get: {method: "JSONP"}});
//    $scope.GroupList = $scope.GroupAPI.get({        
//    });
//    console.log($scope.GroupList);
    
//    function fetch(){
//  $http.get("http://localhost:52488/api/Groups/GetGroups")
//  .then(function(response){ $scope.details = response.data;console.log($scope.details); });
//    }
//    
  
    $http.get("https://localhost:44344/api/Groups/GetGroups")
    .success(function(result){
        $scope.rules = result;
        console.log(result);
        
    })
    .error(function(data,status){
        console.log(data);
    })
   
}]);
