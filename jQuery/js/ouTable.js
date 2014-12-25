var ouTable = new Object();

//************* 1.0 全局控件(三个文本框和一个下拉框)**************
//1.1 全局--捐款人文本框
ouTable.editTxtName = document.createElement("input");
ouTable.editTxtName.type = "text";
//1.2 全局--金额文本框
ouTable.editTxtMoney = document.createElement("input");
ouTable.editTxtMoney.type = "text";
//1.3 全局--日期文本框
ouTable.editTxtDate = document.createElement("input");
ouTable.editTxtDate.type = "text";
//1.4 全局--受捐单位下拉框
ouTable.editSelOrg = document.createElement("select");

//************ 2.0 初始化数据***************************************
ouTable.init = function (parentId, colsDeclare, data) {
    //2.1 设置受捐单位数组
    this.listOrgs = data.listOrgs;
    //2.2 设置捐款数组
    this.listMoney = data.listMoney;
    //2.3 设置表格父容器
    this.parent = document.getElementById(parentId);
}
