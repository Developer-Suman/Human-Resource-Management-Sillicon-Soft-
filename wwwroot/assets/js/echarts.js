$((function(e){"use strict";var t=[{name:"sales",type:"bar",data:[10,15,9,18,10,15]},{name:"profit",type:"line",smooth:!0,data:[8,5,25,10,10]},{name:"growth",type:"bar",data:[10,14,10,15,9,25]}],i=document.getElementById("echart1"),o={grid:{top:"6",right:"0",bottom:"17",left:"25"},xAxis:{data:["2014","2015","2016","2017","2018"],axisLine:{lineStyle:{color:"rgba(67, 87, 133, .09)"}},axisLabel:{fontSize:10,color:"#8e9cad"}},tooltip:{show:!0,showContent:!0,alwaysShowContent:!0,triggerOn:"mousemove",trigger:"axis",axisPointer:{label:{show:!1}}},yAxis:{splitLine:{lineStyle:{color:"rgba(67, 87, 133, .09)"}},axisLine:{lineStyle:{color:"rgba(67, 87, 133, .09)"}},axisLabel:{fontSize:10,color:"#8e9cad"}},series:t,color:["#3366ff","#01c353","#fe7f00"]};echarts.init(i).setOption(o);var a=[{name:"sales",type:"line",smooth:!0,data:[12,25,12,35,12,38],color:["#3366ff"]},{name:"Profit",type:"line",smooth:!0,size:10,data:[8,12,28,10,10,12],color:["#fe7f00"]}],l=document.getElementById("echart2"),r={grid:{top:"6",right:"0",bottom:"17",left:"25"},xAxis:{data:["2014","2015","2016","2017","2018"],axisLine:{lineStyle:{color:"rgba(67, 87, 133, .09)"}},axisLabel:{fontSize:10,color:"#8e9cad"}},yAxis:{splitLine:{lineStyle:{color:"rgba(67, 87, 133, .09)"}},axisLine:{lineStyle:{color:"rgba(67, 87, 133, .09)"}},axisLabel:{fontSize:10,color:"#8e9cad"}},series:a};echarts.init(l).setOption(r);var n={grid:{top:"6",right:"0",bottom:"17",left:"32"},xAxis:{type:"value",axisLine:{lineStyle:{color:"rgba(67, 87, 133, .09)"}},axisLabel:{fontSize:10,color:"#8e9cad"},splitLine:{lineStyle:{color:"rgba(67, 87, 133, .09)"}}},yAxis:{type:"category",data:["2014","2015","2016","2017","2018"],axisLine:{lineStyle:{color:"#c0dfd8"}},axisLabel:{fontSize:10,color:"#8e9cad"}},series:t,color:["#3366ff","#01c353","#fe7f00"]},s=document.getElementById("echart3");echarts.init(s).setOption(n);var c={grid:{top:"6",right:"0",bottom:"17",left:"32"},xAxis:{type:"value",axisLine:{lineStyle:{color:"rgba(67, 87, 133, .09)"}},axisLabel:{fontSize:10,color:"#8e9cad"},splitLine:{lineStyle:{color:"rgba(67, 87, 133, .09)"}}},yAxis:{type:"category",data:["2014","2015","2016","2017","2018"],axisLine:{lineStyle:{color:"rgba(67, 87, 133, .09)"}},axisLabel:{fontSize:10,color:"#8e9cad"}},series:a,color:["#3366ff","#fe7f00","#01c353"]},d=document.getElementById("echart4");echarts.init(d).setOption(c);var y=[{name:"sales",type:"bar",stack:"Stack",data:[14,18,20,14,29,21,25,14,24]},{name:"Profit",type:"bar",stack:"Stack",data:[12,14,15,50,24,24,10,20,30]}],x={grid:{top:"6",right:"0",bottom:"17",left:"25"},xAxis:{data:["2010","2011","2012","2013","2014","2015","2016","2017","2018"],axisLine:{lineStyle:{color:"rgba(67, 87, 133, .09)"}},axisLabel:{fontSize:10,color:"#8e9cad"}},yAxis:{splitLine:{lineStyle:{color:"rgba(67, 87, 133, .09)"}},axisLine:{lineStyle:{color:"rgba(67, 87, 133, .09)"}},axisLabel:{fontSize:10,color:"#8e9cad"}},series:y,color:["#3366ff","#fe7f00"]},f=document.getElementById("echart5");echarts.init(f).setOption(x);var g={grid:{top:"6",right:"10",bottom:"17",left:"32"},xAxis:{type:"value",axisLine:{lineStyle:{color:"rgba(67, 87, 133, .09)"}},axisLabel:{fontSize:10,color:"#8e9cad"},splitLine:{lineStyle:{color:"rgba(67, 87, 133, .09)"}}},yAxis:{type:"category",data:["2010","2011","2012","2013","2014","2015","2016","2017","2018"],axisLine:{lineStyle:{color:"rgba(67, 87, 133, .09)"}},axisLabel:{fontSize:10,color:"#8e9cad"}},series:y,color:["#3366ff","#fe7f00"]},b=document.getElementById("echart6");echarts.init(b).setOption(g);var S={grid:{top:"6",right:"0",bottom:"17",left:"25"},xAxis:{data:["2011","2012","2013","2014","2015","2016","2017","2018"],axisLine:{lineStyle:{color:"rgba(67, 87, 133, .09)"}},axisLabel:{fontSize:10,color:"#8e9cad"}},yAxis:{splitLine:{lineStyle:{color:"rgba(67, 87, 133, .09)"}},axisLine:{lineStyle:{color:"rgba(67, 87, 133, .09)"}},axisLabel:{fontSize:10,color:"#8e9cad"}},series:[{name:"data",type:"line",data:[20,20,36,18,15,20,25,20]}],color:["#3366ff"]},p=document.getElementById("echart7");echarts.init(p).setOption(S);var L={grid:{top:"6",right:"0",bottom:"17",left:"25"},xAxis:{data:["2011","2012","2013","2014","2015","2016","2017","2018"],axisLine:{lineStyle:{color:"rgba(67, 87, 133, .09)"}},axisLabel:{fontSize:10,color:"#8e9cad"}},yAxis:{splitLine:{lineStyle:{color:"rgba(67, 87, 133, .09)"}},axisLine:{lineStyle:{color:"rgba(67, 87, 133, .09)"}},axisLabel:{fontSize:10,color:"#8e9cad"}},series:[{name:"data",type:"line",smooth:!0,data:[20,20,36,18,15,20,25,20]}],color:["#fe7f00"]},m=document.getElementById("echart8");echarts.init(m).setOption(L)}));