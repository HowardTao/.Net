//**********************1.定义"数据源"*********************
//********1.1受捐单位数组*********
var listOrgs = new Array();
//1.1.1初始化单位数组数据
listOrgs[0] = { id: "1", name: "壹基金" };
listOrgs[1] = { id: "2", name: "慈济基金" };
listOrgs[2] = { id: "3", name: "宋庆龄" };

//1.1.2扩展一个根据id查找受捐单位对象的方法
listOrgs.findOrgById = function (fid) {
    //方法里的this就是这个受捐单位数组
    for (var i = 0; i < this.length; i++) {
        //如果当前循环到的单位对象id就是要在的id,则返回这个单位对象
        if (this[i].id == fid) {
            return this[i];
        }
    }
};

//**********1.2捐款数据数组***********
var listMoney = new Array();
//1.2.1为捐款数组扩展一个更新数据方法
listMoney.modify = function (dataObj) {
    //遍历捐款数组,找到要更新的捐款对象,然后修改属性
    for (var i = 0; i < this.length; i++) {
        if (this[i].id == dataObj.id) {
            this[i].pname = dataObj.pname;
            this[i].orgId = dataObj.orgId;
            this[i].money = dataObj.money;
            this[i].date = dataObj.date;
            break;//已经找到,跳出循环.
        }
    }
};

//1.2.2为捐款数组扩展一个删除方法
listMoney.deleteById = function (id) {
    //a.根据id找到要删除的元素的下标
    var delIndex = -1;
    for (var i = 0; i < this.length; i++) {
        if (this[i].id = id) {
            delIndex = i;//保存要删除的元素下标
            break;
        }
    }
    //b.根据要删除的下标,将后面的元素向前移动一位
    for (var i = delIndex; i < this.length - 1; i++) {
        this[i] = this[i + 1];
    }
    //c.删除最后一个元素
    this.length = this.length - 1;
    listMoney.countPage();//每次删除捐款数据都重新计算总页数
};

//1.2.3为捐款数组扩展两个新增的方法
listMoney.countId = 1;
listMoney.add = function (pname, orgId, money, date) {
    var newObj = {
        "pname": pname,
        "orgId": orgId,
        "money": money,
        "date": date
    };
    return this.addObj(newObj);
};
listMoney.addObj = function (dataObj) {
    var newObj = {
        "id": listMoney.countId,
        "pname": dataObj.pname,
        "orgId": dataObj.orgId,
        "money": dataObj.money,
        "date": dataObj.date
    };
    //为数组追加一个新元素
    this[this.length] = newObj;
    //id计数++
    listMoney.countId++;
    listMoney.countPage();
    return newObj;
};

//1.2.4为捐款数组扩展分页参数
listMoney.pageCount = 0;//总页数
listMoney.pageSize = 5;//页容量
listMoney.pageIndex = 0;//当前页码

//1.2.4.1获取下一页数据
listMoney.getNextPage = function () {
    this.pageIndex++;//页码+1
    if (this.pageIndex > this.pageCount) {
        this.pageIndex--;
        alert("已经是最后一页了!!");
        return;
    }
    //根据页码请求的分页数据数组
    var pagedList = new Array();
    //先算出当前页的最后一行行号
    var lastRowTemp = this.pageIndex * this.pageSize;
    //判断,如果行号超过了数组的长度,则返回数组长度
    var nowPageLastRow = lastRowTemp > this.length ? this.length : lastRowTemp;
    //根据当前页码循环取出当前页的所有数据,并转入数组返回
    for (var i = (this.pageIndex - 1) * this.pageSize; i < nowPageLastRow; i++) {
        pagedList[pagedList.length] = this[i];
    }
    //gel("spanPageIndex").innerHTML = this.pageIndex;
    return pagedList;//返回分页数据
};

//1.2.4.2获取上一页数据
listMoney.getPrePage = function () {
    this.pageIndex--;//页码+1
    if (this.pageIndex < 1) {
        this.pageIndex++;
        alert("已经是第一页页了~~！");
        return;
    }
    //根据页码请求的分页数据 数组
    var pagedList = new Array();
    //先算出 当前页的最后一行行号
    var lastRowTemp = this.pageIndex * this.pageSize;
    //根据当前页码 循环取出 当前页的所有数据，并装入数组返回
    for (var i = (this.pageIndex - 1) * this.pageSize; i < lastRowTemp; i++) {
        pagedList[pagedList.length] = this[i];
    }
    //gel("spanPageIndex").innerHTML = this.pageIndex;
    return pagedList;//返回分页数据
};

//1.2.4.3根据当前数组长度计算总页数（在 每当 向数组中 添加或移除数据 的时候调用）
listMoney.countPage = function () {
    //根据数组长度和页容量 求出总页数（使用天花板函数 为带小数的结果加1）
    this.pageCount = Math.ceil(this.length / this.pageSize);
    //gel("spanPageCount").innerHTML = this.pageCount;
};

//1.2.5根据 受捐单位 id 查询其捐款数据
listMoney.findMoneyByOrgId = function (orgId) {
    var resultArr = new Array();//保存 查询到的 捐款数据
    //遍历 当前捐款数组
    for (var i = 0; i < this.length; i++) {
        //查找 捐款的受捐单位 为 被搜索的 单位id一致 的捐款
        if (this[i].orgId == orgId || orgId == -1) {//如果 orgId为-1，则加入所有的 捐款
            resultArr[resultArr.length] = this[i];//将 此笔捐款 加入搜索结果 数组
        }
    }
    return resultArr;//返回结果数组
};