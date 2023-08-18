//slider slick
$(document).ready(function(){
    $('.image-slider').slick({
        slidesToShow: 4,
        slidesToScroll: 1,
        infinite: true,
        arrows: false,
        draggable: true,
        dots: false,
        responsive: [
          {
            breakpoint: 768,
            settings: {
              slidesToShow: 2,
            },
          },
          {
            breakpoint: 576,
            settings: {
              slidesToShow: 1,
              arrows: false,
              infinite: false,
            },
          },
        ],
        autoplay: true,
        autoplaySpeed: 1000,
      });
    });

// Counting up
// let nums = document.querySelectorAll(".numero");
let nums = document.querySelectorAll(".numero");
let intervalNum = 5000;

nums.forEach((num) => {
  let startNum = 0;
  let endNum  = parseInt(num.getAttribute("data-val"));
 console.log(endNum);
  let durationFunction = Math.floor(intervalNum / endNum);
  let counterNum = setInterval(function() {
    startNum += 1;
    num.textContent = startNum;

    if(startNum == endNum) {
      clearInterval(counterNum);
    }
  }, durationFunction);

});


var barChartOptions = {
  series: [{
    data: [100,150,70,90]
  }],
  chart: {
    type: 'bar',
    height: 350,
    toolbar: {
      show: false
    },
  },
  colors: [
    "#246dec",
    "#cc3c43",
    "#367952",
    "#f5b74f",
    "#4f35a1"
  ],
  plotOptions: {
    bar: {
      distributed: true,
      borderRadius: 4,
      horizontal: false,
      columnWidth: '40%',
    }
  },
  dataLabels: {
    enabled: false
  },
  legend: {
    show: false
  },
  xaxis: {
    categories: ["Janvier", "Février", "Mars", "Avril"],
  },
  yaxis: {
    title: {
      text: "Nombre des films"
    }
  }
};

var barChart = new ApexCharts(document.querySelector("#bar-chart"), barChartOptions);
barChart.render();


var areaChartOptions = {
  series: [{
    name: 'Coûts',
    data: [25468, 30794, 27647,15487]
  }, {
    name: 'Revenus',
    data: [45167,56497,35797,48167]
  }],
  chart: {
    height: 350,
    type: 'area',
    toolbar: {
      show: false,
    },
  },
  colors: ["#4f35a1", "#246dec"],
  dataLabels: {
    enabled: false,
  },
  stroke: {
    curve: 'smooth'
  },
  labels: ["Janvier", "Février", "Mars", "Avril"],
  markers: {
    size: 0
  },
  yaxis: [
    {
      title: {
        text: 'Coûts',
      },
    },
    {
      opposite: true,
      title: {
        text: 'Revenus',
      },
    },
  ],
  tooltip: {
    shared: true,
    intersect: false,
  }
};

var areaChart = new ApexCharts(document.querySelector("#area-chart"), areaChartOptions);
areaChart.render();
