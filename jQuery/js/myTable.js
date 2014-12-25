//在js中告诉开发工具jquery文件的位置,方便开发工具生成提示
///<reference path="jquery-1.11.1.js"/>
var myTable = new Object();

//表格列的定义数组
myTable.colsDef = null;
//编辑状态行对象
myTable.editingRow = null;
//****************************************************************
//0.1创建表格对象
myTable.table = $("<table id=\"tbData\"><tr></tr></table>");

//1.初始化方法,传入容器id(表格的父容器id),列的定义数据,表格数据
/*
     parentId:父容器id
     colsDef:列的定义数据
                    [{title:"标题",property:"cTitle"},
                     {title:"内容",property:"cContent"}
                    ]
*/
myTable.init = function (parentId, colsDef) {
    //1.0创建编辑状态行对象
    myTable.editingRow = $("<tr></tr>");
    //1.1将表格对象加入到容器中
    $("#" + parentId).append(this.table);
    this.colsDef = colsDef;
    //1.2遍历列定义数组,生成表头
    $.each(colsDef, function (index, value) {
        //向表格的tbody的第一行追加一个单元格
        myTable.table.children().children("tr:first").append($("<th>" + value.title + "</th>"));
        //1.3变量列定义数组,生成编辑状态的单元格,并添加到编辑状态行中
        //注意:此时的editModle可能是html标签字符串,也可能是一个已经生成好的dom对象
        //所以通过typeof判断是否是字符串
        if ((typeof colsDef.editModle).toLowerCase() == "string") {
            myTable.editingRow.append($("<tb>" + colsDef.editModle + "</td>"));
        } else {
            myTable.editingRow.append($("<td></td>").append(colsDef.editModle))
        }
    });
};

//2.绘制表格(根据传入数据显示表格 -- 将"数据行"转换成表格行)
myTable.showData = function (data) {
    //2.1遍历数据数组,每个数组元素或是一条数据
    for (var i = 0; i < data.length; i++) {
        //2.2取出当前循环的一个数据行对象
        var rowData = data[i];
        //2.3创建一个表格行
        var $trNew = $("<tr></tr>");
        //2.4遍历列定义数组,每次为表格生成一个列
        for (var j = 0; j < this.colsDef.length; j++) {
            //2.5获取列定义,如{title:"序号",property:"id"}
            var colDef = this.colsDef[j];
            //2.6获取要显示在列里的行数据对象的属性名
            var colValueName = colDef.property;
            //2.7判断该列是否存在用户格式化方法 -- 就是提供给开发者自定义单元格内容用的
            if (!colDef.formatter || !(colDef.formatter instanceof Function)) {
                //2.7.1如果不存在,则直接显示数据列里的你内容
                //生成一个新列并添加到新行中[列的数据是根据列定义.property获取到要读取的数据行对象属性]
                $trNew.append($("<td>" + rowData[colValueName] + "</td>"));
            }
            else
            {
                //2.7.2如果存在,则调用用户格式化方法,并传入数据行对象
                $trNew.append($("<td>" + colDef.formatter(rowData) + "</td>"));
            }
        }
        //2.8将新行添加到表格中
        $trNew.appendTo(this.table);
    }
};

//3.删除行(funcWhere:开发者传入的删除行的条件方法返回bool值)
myTable.delRow = function (funcWhere) {
    //3.1获取除去表头的所有行
    var $trs = myTable.table.children().children("tr:gt(0)");
    //3.2遍历所有行
    for (var i = 0; i < $trs.length; i++) {
        //3.3在行里面根据用户条件找到对应行
        if (funcWhere($trs.eq(i))) {
            //3.4找到用户要删除的行,执行删除
            $trs.eq(i).remove();
        }
    }
}

//老行:进入编辑状态之前的行
myTable.oldRow = null;
//4.进入编辑状态
myTable.inEdit = function (editBtnObj) {
    //4.1现将上一次要修改的行还原
    if (myTable.oldRow != null) {
        myTable.oldRow.replaceAll($(myTable.editingRow));
    }
    //4.2将要编辑的行存入插件的变量中临时保存
    myTable.oldRow = $(editBtnObj).parent().parent();
    //4.3将编辑状态行替换当前要编辑的行
    $(myTable.editingRow).replaceAll(myTable.oldRow);
}


