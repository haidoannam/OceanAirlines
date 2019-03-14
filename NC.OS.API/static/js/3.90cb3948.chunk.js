(window.webpackJsonp=window.webpackJsonp||[]).push([[3],{414:function(e,t,a){},415:function(e,t,a){},416:function(e,t,a){"use strict";Object.defineProperty(t,"__esModule",{value:!0}),t.default=void 0;var n,r,l=function(){function e(e,t){for(var a=0;a<t.length;a++){var n=t[a];n.enumerable=n.enumerable||!1,n.configurable=!0,"value"in n&&(n.writable=!0),Object.defineProperty(e,n.key,n)}}return function(t,a,n){return a&&e(t.prototype,a),n&&e(t,n),t}}();t.confirmAlert=function(e){document.body.classList.add("react-confirm-alert-body-element"),function(){if(document.getElementById("react-confirm-alert-firm-svg"))return;var e="http://www.w3.org/2000/svg",t=document.createElementNS(e,"feGaussianBlur");t.setAttribute("stdDeviation","0.3");var a=document.createElementNS(e,"filter");a.setAttribute("id","gaussian-blur"),a.appendChild(t);var n=document.createElementNS(e,"svg");n.setAttribute("id","react-confirm-alert-firm-svg"),n.setAttribute("class","react-confirm-alert-svg"),n.appendChild(a),document.body.appendChild(n)}(),function(e){var t=document.getElementById("react-confirm-alert");t?(0,i.render)(o.default.createElement(d,e),t):(document.body.children[0].classList.add("react-confirm-alert-blur"),(t=document.createElement("div")).id="react-confirm-alert",document.body.appendChild(t),(0,i.render)(o.default.createElement(d,e),t))}(e)};var c=a(0),o=m(c),s=m(a(1)),i=a(118);function m(e){return e&&e.__esModule?e:{default:e}}function u(e,t){if(!e)throw new ReferenceError("this hasn't been initialised - super() hasn't been called");return!t||"object"!==typeof t&&"function"!==typeof t?e:t}var d=(r=n=function(e){function t(){var e,a,n;!function(e,t){if(!(e instanceof t))throw new TypeError("Cannot call a class as a function")}(this,t);for(var r=arguments.length,l=Array(r),c=0;c<r;c++)l[c]=arguments[c];return a=n=u(this,(e=t.__proto__||Object.getPrototypeOf(t)).call.apply(e,[this].concat(l))),n.handleClickButton=function(e){e.onClick&&e.onClick(),n.close()},n.handleClickOverlay=function(e){var t=n.props.onClickOutside;e.target===n.overlay&&(t(),n.close())},n.close=function(){document.body.classList.remove("react-confirm-alert-body-element"),function(){var e=document.getElementById("react-confirm-alert");(0,i.unmountComponentAtNode)(e),e.parentNode.removeChild(e)}(),function(){var e=document.getElementById("react-confirm-alert-firm-svg");e.parentNode.removeChild(e),document.body.children[0].classList.remove("react-confirm-alert-blur")}()},n.keyboardClose=function(e){var t=n.props.onKeypressEscape;27===e.keyCode&&(t(e),n.close())},n.componentDidMount=function(){document.addEventListener("keydown",n.keyboardClose,!1)},n.componentWillUnmount=function(){document.removeEventListener("keydown",n.keyboardClose,!1),n.props.willUnmount()},n.renderCustomUI=function(){var e=n.props,t=e.title,a=e.message;return(0,e.customUI)({title:t,message:a,onClose:n.close})},u(n,a)}return function(e,t){if("function"!==typeof t&&null!==t)throw new TypeError("Super expression must either be null or a function, not "+typeof t);e.prototype=Object.create(t&&t.prototype,{constructor:{value:e,enumerable:!1,writable:!0,configurable:!0}}),t&&(Object.setPrototypeOf?Object.setPrototypeOf(e,t):e.__proto__=t)}(t,c.Component),l(t,[{key:"render",value:function(){var e=this,t=this.props,a=t.title,n=t.message,r=t.buttons,l=t.childrenElement,c=t.customUI;return o.default.createElement("div",{className:"react-confirm-alert-overlay",ref:function(t){return e.overlay=t},onClick:this.handleClickOverlay},o.default.createElement("div",{className:"react-confirm-alert"},c?this.renderCustomUI():o.default.createElement("div",{className:"react-confirm-alert-body"},a&&o.default.createElement("h1",null,a),n,l(),o.default.createElement("div",{className:"react-confirm-alert-button-group"},r.map(function(t,a){return o.default.createElement("button",{key:a,onClick:function(){return e.handleClickButton(t)}},t.label)})))))}}]),t}(),n.propTypes={title:s.default.string,message:s.default.string,buttons:s.default.array.isRequired,childrenElement:s.default.func,customUI:s.default.func,willUnmount:s.default.func,onClickOutside:s.default.func,onKeypressEscape:s.default.func},n.defaultProps={buttons:[{label:"Cancel",onClick:function(){return null}},{label:"Confirm",onClick:function(){return null}}],childrenElement:function(){return null},willUnmount:function(){return null},onClickOutside:function(){return null},onKeypressEscape:function(){return null}},r);t.default=d},417:function(e,t,a){},418:function(e,t,a){},419:function(e,t,a){},420:function(e,t,a){},421:function(e,t,a){},422:function(e,t,a){},423:function(e,t,a){},424:function(e,t,a){"use strict";a.r(t);var n=a(12),r=a(13),l=a(16),c=a(14),o=a(15),s=a(21),i=a(0),m=a.n(i),u=(a(414),a(415),function(e){function t(e){var a;return Object(n.a)(this,t),(a=Object(l.a)(this,Object(c.a)(t).call(this,e))).state={},a}return Object(o.a)(t,e),Object(r.a)(t,[{key:"render",value:function(){var e=this.props.tableHeaders,t=!!(e&&e.length>0)?e.map(function(e,t){return m.a.createElement("div",{key:t,style:{flexGrow:e.grow},className:"thead flex-basis-1"},e.name)}):"";return m.a.createElement(m.a.Fragment,null,t)}}]),t}(m.a.Component)),d=a(31),p=a(110),f=a(416),b=(a(417),a(418),{ADD:"Add",DELETE:"Delete",EDIT:"Edit",VIEW:"View",UPDATE:"Update"}),h=function(e){function t(e){var a;Object(n.a)(this,t);var r=(a=Object(l.a)(this,Object(c.a)(t).call(this,e))).props,o=r.dataItem,i=r.tableName;return a.state={isEditing:!1,data:o,action:{},tableName:i,v:1},a.handlerAction=a.handlerAction.bind(Object(s.a)(Object(s.a)(a))),a}return Object(o.a)(t,e),Object(r.a)(t,[{key:"handlerAction",value:function(e){var t=this,a=this.props.settingData.actions;switch(e){case b.EDIT:this.setState({isEditing:!0,v:this.state.v+1});break;case b.UPDATE:(0,a.find(function(e){return e.name===b.EDIT}).action)(this.state.data).then(function(e){t.setState({isEditing:!1,v:t.state.v+1}),p.ToastStore.success("Updated successfully!",3e3)}).catch(function(e){p.ToastStore.error("Update failed!",3e3)});break;case b.ADD:break;case b.DELETE:var n=this,r=a.find(function(e){return e.name===b.DELETE}).action;Object(f.confirmAlert)({title:"Confirm to delete",message:"Are you sure to delete this menu item?",buttons:[{label:"Yes",onClick:function(){r(n.state.data.id,n.state.tableName)(n.props.dispatch)}},{label:"No"}]})}}},{key:"componentWillReceiveProps",value:function(e){this.props.dataItem.id!==e.dataItem.id&&this.setState({data:e.dataItem,v:this.state.v+1})}},{key:"shouldComponentUpdate",value:function(e,t){return this.state.v!==t.v}},{key:"render",value:function(){var e=this,t=this.props.settingData,a=t.tableHeaders,n=t.actions,r=a?a.map(function(t,a){var r=t.grow;if("action"===t.type){var l=!!(n&&n.length>0),c="";return c=e.state.isEditing?m.a.createElement("button",{className:"action-button",style:{color:"#26C281"},onClick:function(){return e.handlerAction(b.UPDATE)}},m.a.createElement("i",{className:"fas fa-sync-alt"})):l?n.map(function(t,a){return m.a.createElement("button",{key:a,className:"action-button",style:{color:t.color},onClick:function(){return e.handlerAction(t.name)}},m.a.createElement("i",{className:t.icon}))}):null,m.a.createElement("div",{className:"tcol flex-basis-1",style:{flexGrow:r},key:a},c)}var o=e.state.isEditing?m.a.createElement("input",{type:"text",className:"line-edit",onChange:function(a){var n=e.state.data;n[t.name]=a.target.value,e.setState({data:n,v:e.state.v+1})},value:e.state.data[t.name]}):m.a.createElement("span",null,e.state.data[t.name]);return m.a.createElement("div",{className:"tcol flex-basis-1",style:{flexGrow:r},key:a},o)}):null;return m.a.createElement("div",{className:"trow display-flex"},r,m.a.createElement(p.ToastContainer,{store:p.ToastStore,position:p.ToastContainer.POSITION.TOP_RIGHT,lightBackground:!0}))}}]),t}(m.a.Component),v=Object(d.b)()(h),E=(a(419),function(e){function t(e){var a;return Object(n.a)(this,t),(a=Object(l.a)(this,Object(c.a)(t).call(this,e))).state={tableName:a.props.tableName},a}return Object(o.a)(t,e),Object(r.a)(t,[{key:"shouldComponentUpdate",value:function(e){return this.props.v!==e.v&&this.tableName===e.upcomingName}},{key:"render",value:function(){var e=this.props,t=e.data,a=e.settingData,n=e.tableName,r=!!(t&&t.length>0)?t.map(function(e,t){return m.a.createElement(v,{key:t,dataItem:e,settingData:a,tableName:n})}):null;return m.a.createElement(m.a.Fragment,null,r)}}]),t}(m.a.Component)),y=Object(d.b)(function(e){if(e.table){var t=e.table;return{data:t.data,v:t.v}}return{}})(E),N=function(e){function t(e){var a;return Object(n.a)(this,t),(a=Object(l.a)(this,Object(c.a)(t).call(this,e))).state={},a}return Object(o.a)(t,e),Object(r.a)(t,[{key:"render",value:function(){var e=this.props,t=e.tableHeaders,a=e.tableBody,n=e.tableActions,r=e.tableName;return m.a.createElement("div",{className:"table"},m.a.createElement("div",{className:"table-head display-flex"},m.a.createElement(u,{tableHeaders:t})),m.a.createElement("div",{className:"table-body"},m.a.createElement(y,{tableName:r,data:a,settingData:{tableHeaders:t,actions:n}})),m.a.createElement("div",{className:"table-footer display-flex"},this.props.children))}}]),t}(m.a.Component),g=(a(420),a(421),function(e){function t(){return Object(n.a)(this,t),Object(l.a)(this,Object(c.a)(t).apply(this,arguments))}return Object(o.a)(t,e),Object(r.a)(t,[{key:"render",value:function(){var e=this;return m.a.createElement("button",{className:"action btn btn-green small",onClick:function(){return e.props.handlerAction()}},m.a.createElement("i",{className:this.props.actionIcon}),m.a.createElement("span",null,this.props.actionName))}}]),t}(m.a.Component)),O=function(e){function t(){return Object(n.a)(this,t),Object(l.a)(this,Object(c.a)(t).apply(this,arguments))}return Object(o.a)(t,e),Object(r.a)(t,[{key:"render",value:function(){var e=this.props.hasAction?m.a.createElement(g,this.props):"";return m.a.createElement("div",{className:"form-title display-flex align-items-center"},m.a.createElement("div",{className:"display-flex title align-items-center"},m.a.createElement("i",{className:this.props.icon}),m.a.createElement("span",null,this.props.title)),e)}}]),t}(m.a.Component),j=(a(422),function(e){function t(){return Object(n.a)(this,t),Object(l.a)(this,Object(c.a)(t).apply(this,arguments))}return Object(o.a)(t,e),Object(r.a)(t,[{key:"shouldComponentUpdate",value:function(){return!1}},{key:"render",value:function(){return m.a.createElement("div",{className:"form-bottom display-flex align-items-center"},m.a.createElement(g,this.props))}}]),t}(m.a.Component)),k=a(406),C=a(405),w=a(174),x=function(e){function t(e){var a;Object(n.a)(this,t);var r=(a=Object(l.a)(this,Object(c.a)(t).call(this,e))).props.options;return a.state={options:r||[],total:0},a}return Object(o.a)(t,e),Object(r.a)(t,[{key:"componentDidMount",value:function(){var e=this,t=this.props,a=t.loadData,n=t.convertData;a&&this.props.loadData().then(function(t){var a=n(t.rows);e.setState({options:a,total:t.count})}).catch(function(e){console.log(e)})}},{key:"render",value:function(){var e=this.props,t=e.defaultNull,a=e.name,n=this.state.total,r=n>1?n+1:2;return r=r>10?10:r,0===this.state.count?"":m.a.createElement(k.a,{className:"form-control",name:a,component:this.props.renderSelect,defaultNull:t,options:this.state.options,size:r,label:this.props.label,placeholder:this.props.placeholder})}}]),t}(m.a.Component),A=function(e){var t=e.input,a=e.className,n=e.label,r=e.placeholder,l=e.type,c=e.required,o=e.meta,s=o.touched,i=o.error,u=o.warning,d=c?m.a.createElement("span",{className:"label"},n,m.a.createElement("span",{className:"required"},"*")," "):m.a.createElement("span",{className:"label"},n);return m.a.createElement(m.a.Fragment,null,d,m.a.createElement("input",Object.assign({className:a},t,{placeholder:r,required:c,type:l}))," ",s&&(i&&m.a.createElement("span",{className:"message error"},i)||u&&m.a.createElement("span",{className:"message warning"},u)))},D=function(e){var t=e.input,a=e.className,n=e.label,r=e.placeholder,l=e.required,c=e.defaultNull,o=e.options,s=e.meta,i=s.touched,u=s.error,d=s.warning,p=l?m.a.createElement("span",{className:"label"},n,m.a.createElement("span",{className:"required"},"*")," "):m.a.createElement("span",{className:"label"},n),f=[];return c&&f.push(m.a.createElement("option",{key:0,value:""},"---"+r+"---")),f=f.concat(o),m.a.createElement(m.a.Fragment,null,p,m.a.createElement("select",Object.assign({},t,{value:t.value,className:a,placeholder:r,required:l}),f),i&&(u&&m.a.createElement("span",{className:"message error"},u)||d&&m.a.createElement("span",{className:"message warning"},d)))},T=a(108),I={TABLE_ORDERS:"tableProductType"},S=(a(423),function(e){function t(e){var a;return Object(n.a)(this,t),(a=Object(l.a)(this,Object(c.a)(t).call(this,e))).state={path:"orders",tableHeaders:[{name:"ID",grow:1,type:"text",editale:!0},{name:"Sender name",grow:2,type:"text",editale:!0},{name:"From",grow:2,type:"text",editale:!0},{name:"To",grow:2,type:"text",editale:!0},{name:"Status",grow:2,type:"text",editale:!0},{name:"actions",grow:1,type:"action"}],tableBody:[]},a.createOrder=a.createOrder.bind(Object(s.a)(Object(s.a)(a))),a.submitOrder=a.submitOrder.bind(Object(s.a)(Object(s.a)(a))),a}return Object(o.a)(t,e),Object(r.a)(t,[{key:"createOrder",value:function(){this.setState({path:"createOrder"})}},{key:"submitOrder",value:function(){}},{key:"render",value:function(){var e=this.props,t=e.handleSubmit,a=e.errMsg;return"orders"===this.state.path?m.a.createElement("div",null,m.a.createElement(O,{icon:"fas fa-plus-circle",title:"Orders",actionIcon:"far fa-check-circle",hasAction:!0,actionName:"Create Order",handlerAction:this.createOrder}),m.a.createElement(N,{tableName:I.TABLE_ORDERS,tableHeaders:this.state.tableHeaders,tableActions:this.state.tableActions})):m.a.createElement("div",null,m.a.createElement(O,{icon:"fas fa-plus-circle",title:"New Order",actionIcon:"far fa-check-circle",hasAction:!0,actionName:"Save",handlerAction:t(this.submitOrder)}),m.a.createElement("form",{className:"light margin-top-24"},m.a.createElement("div",{className:"summary-error-msg"},m.a.createElement("span",{className:"message error"},a)),m.a.createElement("div",{className:"users-section display-flex"},m.a.createElement("div",{className:"sender flex-basis-50"},m.a.createElement("div",{className:"form-group"},m.a.createElement(k.a,{type:"text",className:"form-control",name:"senderName",required:!0,component:A,label:"Sender Name",placeholder:"Enter sender name",validate:[T.b]})),m.a.createElement("div",{className:"form-group"},m.a.createElement(k.a,{type:"text",className:"form-control",name:"senderPhone",required:!0,component:A,label:"Sender Phone",placeholder:"Enter sender phone",validate:[T.b]}))),m.a.createElement("div",{className:"receiver flex-basis-50"},m.a.createElement("div",{className:"form-group"},m.a.createElement(k.a,{type:"text",className:"form-control",name:"receiverName",required:!0,component:A,label:"Receiver Name",placeholder:"Enter receiver name",validate:[T.b]})),m.a.createElement("div",{className:"form-group"},m.a.createElement(k.a,{type:"text",className:"form-control",name:"receiverPhone",required:!0,component:A,label:"Receiver Phone",placeholder:"Enter receiver phone",validate:[T.b]})),m.a.createElement("div",{className:"form-group"},m.a.createElement(k.a,{type:"text",className:"form-control",name:"receiverAddress",required:!0,component:A,label:"Receiver Address",placeholder:"Enter receiver address",validate:[T.b]})))),m.a.createElement("hr",{className:"line"}),m.a.createElement("div",{className:"package-section"},m.a.createElement("div",{className:"display-flex"},m.a.createElement("div",{className:"flex-basis-50"},m.a.createElement("div",{className:"form-group"},m.a.createElement(x,{className:"form-control",name:"from",renderSelect:D,defaultNull:!0,label:"From"}))),m.a.createElement("div",{className:"flex-basis-50"},m.a.createElement("div",{className:"form-group"},m.a.createElement(x,{className:"form-control",name:"To",renderSelect:D,defaultNull:!0,label:"To"})))),m.a.createElement("div",{className:"display-flex"},m.a.createElement("div",{className:"flex-basis-25"},m.a.createElement("div",{className:"form-group"},m.a.createElement(k.a,{type:"text",className:"form-control",name:"Height",required:!0,component:A,label:"Height",placeholder:"Enter package height",validate:[T.b]}))),m.a.createElement("div",{className:"flex-basis-25"},m.a.createElement("div",{className:"form-group"},m.a.createElement(k.a,{type:"text",className:"form-control",name:"Depth",required:!0,component:A,label:"Depth",placeholder:"Enter package depth",validate:[T.b]}))),m.a.createElement("div",{className:"flex-basis-25"},m.a.createElement("div",{className:"form-group"},m.a.createElement(k.a,{type:"text",className:"form-control",name:"Breadth",required:!0,component:A,label:"Breadth",placeholder:"Enter package breadth",validate:[T.b]}))),m.a.createElement("div",{className:"flex-basis-25"},m.a.createElement("div",{className:"form-group"},m.a.createElement(k.a,{type:"text",className:"form-control",name:"Weight",required:!0,component:A,label:"Weight",placeholder:"Enter package weight",validate:[T.b]})))),m.a.createElement("div",{className:"calculate-section display-flex"},m.a.createElement("div",{className:"form-group"},m.a.createElement("label",null,"Price:",m.a.createElement("b",null,"10 $")),m.a.createElement("label",{className:"margin-left-24"},"Time:",m.a.createElement("b",null,"2 hours")))))),m.a.createElement(j,{actionIcon:"far fa-check-circle",actionName:"Save",handlerAction:t(this.submitOrder)}))}}]),t}(m.a.Component)),P=Object(w.a)(Object(C.a)({form:"CreateOrderForm"}),Object(d.b)());t.default=P(S)}}]);
//# sourceMappingURL=3.90cb3948.chunk.js.map