using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace change.Models
{
    public class CheckJsonT_SWGD_FORM_HEAD
    {
        /// <summary>
        /// 客户端报关单编号
        /// </summary>
        public string ediNo { get; set; }
        /// <summary>
        /// 海关账号
        /// </summary>
        public string userName { get; set; }
        /// <summary>
        /// 接口版本号 此版本为3.1
        /// </summary>
        public string decVersion { get; set; }
        /// <summary>
        /// 申报单位代码
        /// </summary>
        public string agentCode { get; set; }
        /// <summary>
        /// 申报单位名称
        /// </summary>
        public string agentName { get; set; }
        /// <summary>
        /// 批准文号 实填 外汇核销单号
        /// </summary>
        public string apprNo { get; set; }
        /// <summary>
        /// 提单号
        /// </summary>
        public string billNo { get; set; }
        /// <summary>
        /// 合同号
        /// </summary>
        public string contrNo { get; set; }
        /// <summary>
        /// 主管海关（申报地海关）
        /// </summary>
        public string declPort { get; set; }
        /// <summary>
        /// 征免性质
        /// </summary>
        public string cutMode { get; set; }
        /// <summary>
        /// 数据来源
        /// </summary>
        public string datasource { get; set; }
        /// <summary>
        /// 经停港/抵运港
        /// </summary>
        public string distinatePortStd { get; set; }
        /// <summary>
        /// 报关标志
        /// </summary>
        public string ediId { get; set; }
        /// <summary>
        /// 单证类型 0123456789AB
        /// </summary>
        public string ieFlag { get; set; }
        /// <summary>
        /// 运费币制
        /// </summary>
        public string feeCurrStd { get; set; }
        /// <summary>
        /// 运费标记
        /// </summary>
        public string feeMark { get; set; }
        /// <summary>
        /// 运费／率 海关精度为Z(12).Z(7)
        /// </summary>
        public string feeRate { get; set; }
        /// <summary>
        /// 毛重
        /// </summary>
        public string grossWt { get; set; }
        /// <summary>
        /// 进出口日期 yyyy-MM-dd
        /// </summary>
        public string iEDate { get; set; }
        /// <summary>
        /// 进出口岸
        /// </summary>
        public string iEPort { get; set; }
        /// <summary>
        /// 保险费币制
        /// </summary>
        public string insurCurrStd { get; set; }
        /// <summary>
        /// 保险费标记
        /// </summary>
        public string insurMark { get; set; }
        /// <summary>
        /// 保险费／率  海关精度为Z(12).Z(7)
        /// </summary>
        public string insurRate { get; set; }
        /// <summary>
        /// 许可证编号
        /// </summary>
        public string licenseNo { get; set; }
        /// <summary>
        /// 备案号
        /// </summary>
        public string manualNo { get; set; }
        /// <summary>
        /// 净重
        /// </summary>
        public string netWt { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string noteS { get; set; }
        /// <summary>
        /// 杂费币制
        /// </summary>
        public string otherCurrStd { get; set; }
        /// <summary>
        /// 杂费标志
        /// </summary>
        public string otherMark { get; set; }
        /// <summary>
        /// 杂费／率 海关精度为Z(12).Z(7)
        /// </summary>
        public string otherRate { get; set; }
        /// <summary>
        /// 货主单位代码 10位或9位，或NO
        /// </summary>
        public string ownerCode { get; set; }
        /// <summary>
        /// 货主单位名称
        /// </summary>
        public string ownerName { get; set; }
        /// <summary>
        /// 件数
        /// </summary>
        public string packNo { get; set; }
        /// <summary>
        /// 打印日期 格式为：yyyy-MM-dd
        /// </summary>
        public string printDate { get; set; }
        /// <summary>
        /// 预录入编号
        /// </summary>
        public string preEntryId { get; set; }
        /// <summary>
        /// 数据中心统一编号
        /// </summary>
        public string seqNo { get; set; }
        /// <summary>
        /// 贸易国别
        /// </summary>
        public string tradeCountryStd { get; set; }
        /// <summary>
        /// 贸易方式
        /// </summary>
        public string tradeModeStd { get; set; }
        /// <summary>
        /// 境内收发货人编号
        /// </summary>
        public string tradeCo { get; set; }
        /// <summary>
        /// 运输方式代码
        /// </summary>
        public string trafModeStd { get; set; }
        /// <summary>
        /// 运输工具代码及名称
        /// </summary>
        public string trafName { get; set; }
        /// <summary>
        /// 境内收发货人名称
        /// </summary>
        public string tradeName { get; set; }
        /// <summary>
        /// 成交方式
        /// </summary>
        public string transMode { get; set; }
        /// <summary>
        /// 包装种类
        /// </summary>
        public string wrapTypeStd { get; set; }
        /// <summary>
        /// 担保验放标志
        /// </summary>
        public string chkSurety { get; set; }
        /// <summary>
        /// 备案清单类型
        /// </summary>
        public string billType { get; set; }
        /// <summary>
        /// 经营单位统一编码
        /// </summary>
        public string tradeCoScc { get; set; }
        /// <summary>
        /// 申报代码统一编码
        /// </summary>
        public string agentCodeScc { get; set; }
        /// <summary>
        /// 货主单位统一编码
        /// </summary>
        public string ownerCodeScc { get; set; }
        /// <summary>
        /// 承诺事项
        /// </summary>
        public string promiseItmes { get; set; }
        /// <summary>
        /// 贸易国别
        /// </summary>
        public string tradeAreaCodeStd { get; set; }
        /// <summary>
        /// 查验分流
        /// </summary>
        public string checkFlow { get; set; }
        /// <summary>
        /// 税收征管标记
        /// </summary>
        public string taxAaminMark { get; set; }
        /// <summary>
        /// 标记唛码
        /// </summary>
        public string markNo { get; set; }
        /// <summary>
        /// 启运口岸代码
        /// </summary>
        public string despPortCode { get; set; }
        /// <summary>
        /// 入境口岸代码
        /// </summary>
        public string entyPortCode { get; set; }
        /// <summary>
        /// 存放地点
        /// </summary>
        public string goodsPlace { get; set; }
        /// <summary>
        /// B/L号
        /// </summary>
        public string bLNo { get; set; }
        /// <summary>
        /// 口岸检验检疫机关
        /// </summary>
        public string inspOrgCode { get; set; }
        /// <summary>
        /// 特种业务标识
        /// </summary>
        public string specDeclFlag { get; set; }
        /// <summary>
        /// 目的地检验检疫机关
        /// </summary>
        public string purpOrgCode { get; set; }
        /// <summary>
        /// 启运日期  格式为：yyyy-MM-dd
        /// </summary>
        public string despDate { get; set; }
        /// <summary>
        /// 卸毕日期  格式为：yyyy-MM-dd
        /// </summary>
        public string cmplDschrgDt { get; set; }
        /// <summary>
        /// 关联理由
        /// </summary>
        public string correlationReasonFlag { get; set; }
        /// <summary>
        /// 领证机关
        /// </summary>
        public string vsaOrgCode { get; set; }
        /// <summary>
        /// 原集装箱标识
        /// </summary>
        public string origBoxFlag { get; set; }
        /// <summary>
        /// 报关员姓名
        /// </summary>
        public string declareName { get; set; }
        /// <summary>
        /// 无其他包装
        /// </summary>
        public string noOtherPack { get; set; }
        /// <summary>
        /// 检验检疫受理机关
        /// </summary>
        public string orgCode { get; set; }
        /// <summary>
        /// 境外发货人代码
        /// </summary>
        public string overseasConsignorCode { get; set; }
        /// <summary>
        /// 境外发货人名称
        /// </summary>
        public string overseasConsignorCname { get; set; }
        /// <summary>
        /// 境外发货人名称（外文）
        /// </summary>
        public string overseasConsignorEname { get; set; }
        /// <summary>
        /// 境外发货人地址
        /// </summary>
        public string overseasConsignorAddr { get; set; }
        /// <summary>
        /// 境外收货人编码
        /// </summary>
        public string overseasConsigneeCode { get; set; }
        /// <summary>
        /// 境外收货人名称(外文)
        /// </summary>
        public string overseasConsigneeEname { get; set; }
        /// <summary>
        /// 境内收货人名称（外文）
        /// </summary>
        public string domesticConsigneeEname { get; set; }
        /// <summary>
        /// 关联号码
        /// </summary>
        public string correlationNo { get; set; }
        /// <summary>
        /// 属地申报，口岸验放
        /// </summary>
        public string typeEr { get; set; }
        /// <summary>
        /// EDI申报备注2
        /// </summary>
        public string ediRemark2 { get; set; }
        /// <summary>
        /// 汇总征税
        /// </summary>
        public string collecttax { get; set; }
        /// <summary>
        /// 两单一审
        /// </summary>
        public string twoAudit { get; set; }
        /// <summary>
        /// 保函号
        /// </summary>
        public string taxNo { get; set; }
        /// <summary>
        /// 关联备案号
        /// </summary>
        public string ramanualno { get; set; }
        /// <summary>
        /// 关联报关单号
        /// </summary>
        public string radeclno { get; set; }
        /// <summary>
        /// 监管仓号
        /// </summary>
        public string storeno { get; set; }
        /// <summary>
        /// 航次号
        /// </summary>
        public string voyageNo { get; set; }
        /// <summary>
        /// 货场代码
        /// </summary>
        public string prdtid { get; set; }
        /// <summary>
        /// 境内收发货人检验检疫编码
        /// </summary>
        public string tradeCiqCode { get; set; }
        /// <summary>
        /// 消费使用/生产销售单位检验检疫编码
        /// </summary>
        public string ownerCiqCode { get; set; }
        /// <summary>
        /// 申报单位检验检疫编码
        /// </summary>
        public string declCiqCode { get; set; }
    }

    public class CheckJsonT_SWGD_FORM_LIST
    {
        /// <summary>
        /// 
        /// </summary>
        public string guid { get; set; }
        /// <summary>
        /// 商品编码
        /// </summary>
        public string codeT { get; set; }
        /// <summary>
        /// 附加编码
        /// </summary>
        public string codeS { get; set; }
        /// <summary>
        /// 备案序号
        /// </summary>
        public string contrItem { get; set; }
        /// <summary>
        /// 申报单价 海关精度z(15).z(4)
        /// </summary>
        public string declPrice { get; set; }
        /// <summary>
        /// 申报总价 海关精度z(17).z(2)
        /// </summary>
        public string declTotal { get; set; }
        /// <summary>
        /// 征减免税方式
        /// </summary>
        public string dutyMode { get; set; }
        /// <summary>
        /// 货号
        /// </summary>
        public string goodsId { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        public string prdtNo { get; set; }
        /// <summary>
        /// 第一计量单位（法定单位）
        /// </summary>
        public string firstUnitStd { get; set; }
        /// <summary>
        /// 第一法定数量
        /// </summary>
        public string qtyConv { get; set; }
        /// <summary>
        /// 申报计量单位（成交计量单位）
        /// </summary>
        public string gUnitStd { get; set; }
        /// <summary>
        /// 商品规格、型号 海关精度50
        /// </summary>
        public string gModel { get; set; }
        /// <summary>
        /// 商品名称 海关精度50
        /// </summary>
        public string gName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int gNo { get; set; }
        /// <summary>
        /// 申报数量（成交计量单位）
        /// </summary>
        public string gQty { get; set; }
        /// <summary>
        /// 原产地
        /// </summary>
        public string originCountryStd { get; set; }
        /// <summary>
        /// 第二计量单位
        /// </summary>
        public string secondUnitStd { get; set; }
        /// <summary>
        /// 第二法定数量
        /// </summary>
        public string qty2 { get; set; }
        /// <summary>
        /// 成交币制
        /// </summary>
        public string tradeCurrStd { get; set; }
        /// <summary>
        /// 用途/生产厂家
        /// </summary>
        public string useTo { get; set; }
        /// <summary>
        /// 工缴费 海关精度z(17).z(2)
        /// </summary>
        public string workUsd { get; set; }
        /// <summary>
        /// 最终目的国（地区）
        /// </summary>
        public string destinationCountryStd { get; set; }
        /// <summary>
        /// 检验检疫编码
        /// </summary>
        public string ciqCode { get; set; }
        /// <summary>
        /// 商品英文名称
        /// </summary>
        public string declGoodsEname { get; set; }
        /// <summary>
        /// 原产地区代码
        /// </summary>
        public string origPlaceCode { get; set; }
        /// <summary>
        /// 用途代码
        /// </summary>
        public string purpose { get; set; }
        /// <summary>
        /// 产品有效期 格式：yyyyMMdd
        /// </summary>
        public string prodValidDt { get; set; }
        /// <summary>
        /// 产品保质期
        /// </summary>
        public string prodQgp { get; set; }
        /// <summary>
        /// 货物属性代码
        /// </summary>
        public string goodsAttr { get; set; }
        /// <summary>
        /// 成份/原料/组份
        /// </summary>
        public string stuff { get; set; }
        /// <summary>
        /// UN编码
        /// </summary>
        public string unCode { get; set; }
        /// <summary>
        /// 危险货物名称
        /// </summary>
        public string dangName { get; set; }
        /// <summary>
        /// 危包类别
        /// </summary>
        public string dangPackType { get; set; }
        /// <summary>
        /// 危包规格
        /// </summary>
        public string dangPackSpec { get; set; }
        /// <summary>
        /// 境外生产企业名称
        /// </summary>
        public string engManEntCnm { get; set; }
        /// <summary>
        /// 非危险化学品
        /// </summary>
        public string noDangFlag { get; set; }
        /// <summary>
        /// 目的地代码
        /// </summary>
        public string destCode { get; set; }
        /// <summary>
        /// 检验检疫货物规格
        /// </summary>
        public string goodsSpec { get; set; }
        /// <summary>
        /// 货物型号
        /// </summary>
        public string goodsModel { get; set; }
        /// <summary>
        /// 货物品牌
        /// </summary>
        public string goodsBrand { get; set; }
        /// <summary>
        /// 生产日期 格式：yyyy-MM-dd,多个日期用英文半角分号分隔
        /// </summary>
        public string produceDate { get; set; }
        /// <summary>
        /// 生产批号
        /// </summary>
        public string prodBatchNo { get; set; }
        /// <summary>
        /// 境内目的地/境内货源地
        /// </summary>
        public string districtCode { get; set; }
        /// <summary>
        /// 检验检疫名称
        /// </summary>
        public string ciqName { get; set; }
        /// <summary>
        /// 生产单位注册号
        /// </summary>
        public string mnufctrRegno { get; set; }
        /// <summary>
        /// 生产单位名称
        /// </summary>
        public string mnufctrRegName { get; set; }
    }

    public class CheckJsonT_SWGD_FORM_CLASSIFYSUPItem
    {
        /// <summary>
        /// 品牌中文
        /// </summary>
        public string brandCn { get; set; }
        /// <summary>
        /// 品牌英文
        /// </summary>
        public string brandEn { get; set; }
        /// <summary>
        /// 买方名称
        /// </summary>
        public string buyer { get; set; }
        /// <summary>
        /// 买方联系人
        /// </summary>
        public string buyerContact { get; set; }
        /// <summary>
        /// 买方地址
        /// </summary>
        public string buyerAddr { get; set; }
        /// <summary>
        /// 买方电话
        /// </summary>
        public string buyerTel { get; set; }
        /// <summary>
        /// 卖方名称
        /// </summary>
        public string seller { get; set; }
        /// <summary>
        /// 卖方联系人
        /// </summary>
        public string sellerContact { get; set; }
        /// <summary>
        /// 卖方地址
        /// </summary>
        public string sellerAddr { get; set; }
        /// <summary>
        /// 卖方电话
        /// </summary>
        public string sellerTel { get; set; }
        /// <summary>
        /// 生产厂商名称
        /// </summary>
        public string factory { get; set; }
        /// <summary>
        /// 生产厂商联系人
        /// </summary>
        public string factoryContact { get; set; }
        /// <summary>
        /// 生产厂商地址
        /// </summary>
        public string factoryAddr { get; set; }
        /// <summary>
        /// 生产厂商电话
        /// </summary>
        public string factoryTel { get; set; }
        /// <summary>
        /// 合同协议号
        /// </summary>
        public string contrNo { get; set; }
        /// <summary>
        /// 签约日期
        /// </summary>
        public string contrDate { get; set; }
        /// <summary>
        /// 发票编号
        /// </summary>
        public string invoiceNo { get; set; }
        /// <summary>
        /// 发票日期
        /// </summary>
        public string invoiceDate { get; set; }
        /// <summary>
        /// 商品其他名称
        /// </summary>
        public string gNameOther { get; set; }
        /// <summary>
        /// 进出口国地区海关商品编码  
        /// </summary>
        public string codeTsOther { get; set; }
        /// <summary>
        /// 该商品是否取得过海关预归类决定书
        /// </summary>
        public string isClassDecision { get; set; }
        /// <summary>
        /// 预归类决定书编号
        /// </summary>
        public string decisionNo { get; set; }
        /// <summary>
        /// 预归类决定书商品编码
        /// </summary>
        public string codeTsDecision { get; set; }
        /// <summary>
        /// 作出预归类决定的直属海关
        /// </summary>
        public string decisionCus { get; set; }
        /// <summary>
        /// 该商品是否曾被海关取样化验
        /// </summary>
        public string isSampleTest { get; set; }
        /// <summary>
        /// 商品信息选项
        /// </summary>
        public string gOptions { get; set; }
    }

    public class CheckJsonT_SWGD_FORM_ORIGINALSUPItem
    {
        /// <summary>
        /// 品牌中文
        /// </summary>
        public string brandCn { get; set; }
        /// <summary>
        /// 品牌英文
        /// </summary>
        public string brandEn { get; set; }
        /// <summary>
        /// 买方名称
        /// </summary>
        public string buyer { get; set; }
        /// <summary>
        /// 买方联系人
        /// </summary>
        public string buyerContact { get; set; }
        /// <summary>
        /// 买方地址
        /// </summary>
        public string buyerAddr { get; set; }
        /// <summary>
        /// 买方电话
        /// </summary>
        public string buyerTel { get; set; }
        /// <summary>
        /// 卖方名称
        /// </summary>
        public string seller { get; set; }
        /// <summary>
        /// 卖方联系人
        /// </summary>
        public string sellerContact { get; set; }
        /// <summary>
        /// 卖方地址
        /// </summary>
        public string sellerAddr { get; set; }
        /// <summary>
        /// 卖方电话
        /// </summary>
        public string sellerTel { get; set; }
        /// <summary>
        /// 生产厂商名称
        /// </summary>
        public string factory { get; set; }
        /// <summary>
        /// 生产厂商联系人
        /// </summary>
        public string factoryContact { get; set; }
        /// <summary>
        /// 生产厂商地址
        /// </summary>
        public string factoryAddr { get; set; }
        /// <summary>
        /// 生产厂商电话
        /// </summary>
        public string factoryTel { get; set; }
        /// <summary>
        /// 合同协议号
        /// </summary>
        public string contrNo { get; set; }
        /// <summary>
        /// 签约日期
        /// </summary>
        public string contrDate { get; set; }
        /// <summary>
        /// 发票编号
        /// </summary>
        public string invoiceNo { get; set; }
        /// <summary>
        /// 发票日期
        /// </summary>
        public string invoiceDate { get; set; }
        /// <summary>
        /// 运输方式
        /// </summary>
        public string trafMode { get; set; }
        /// <summary>
        /// 是否直接运输
        /// </summary>
        public string isDirectTraf { get; set; }
        /// <summary>
        /// 中转国地区
        /// </summary>
        public string transitCountry { get; set; }
        /// <summary>
        /// 到货口岸
        /// </summary>
        public string destPort { get; set; }
        /// <summary>
        /// 申报口岸
        /// </summary>
        public string declPort { get; set; }
        /// <summary>
        /// 提单编号 
        /// </summary>
        public string billNo { get; set; }
        /// <summary>
        /// 原产国地区
        /// </summary>
        public string originCountry { get; set; }
        /// <summary>
        /// 原产国地区标记的位置
        /// </summary>
        public string originMark { get; set; }
        /// <summary>
        /// 原产地证书签发机构及所在国家地区
        /// </summary>
        public string certCountry { get; set; }
        /// <summary>
        /// 原产地证书编号
        /// </summary>
        public string certNo { get; set; }
        /// <summary>
        /// 适用的原产地标准
        /// </summary>
        public string certStandard { get; set; }
        /// <summary>
        /// 其他需要说明的情况
        /// </summary>
        public string otherNote { get; set; }
        /// <summary>
        /// 对以上申报内容是否需要海关予以保密
        /// </summary>
        public string isSecret { get; set; }
        /// <summary>
        /// 申报单位类型
        /// </summary>
        public string agentType { get; set; }
        /// <summary>
        /// 申报人单位地址
        /// </summary>
        public string declAddr { get; set; }
        /// <summary>
        /// 申报人邮编
        /// </summary>
        public string declPost { get; set; }
        /// <summary>
        /// 申报人电话
        /// </summary>
        public string declTel { get; set; }
    }

    public class CheckJsonT_SWGD_FORM_PRICESUPItem
    {
        /// <summary>
        /// 品牌中文
        /// </summary>
        public string brandCn { get; set; }
        /// <summary>
        /// 品牌英文
        /// </summary>
        public string brandEn { get; set; }
        /// <summary>
        /// 买方名称
        /// </summary>
        public string buyer { get; set; }
        /// <summary>
        /// 买方联系人
        /// </summary>
        public string buyerContact { get; set; }
        /// <summary>
        /// 买方地址
        /// </summary>
        public string buyerAddr { get; set; }
        /// <summary>
        /// 买方电话
        /// </summary>
        public string buyerTel { get; set; }
        /// <summary>
        /// 卖方名称
        /// </summary>
        public string seller { get; set; }
        /// <summary>
        /// 卖方联系人
        /// </summary>
        public string sellerContact { get; set; }
        /// <summary>
        /// 卖方地址
        /// </summary>
        public string sellerAddr { get; set; }
        /// <summary>
        /// 卖方电话
        /// </summary>
        public string sellerTel { get; set; }
        /// <summary>
        /// 生产厂商名称
        /// </summary>
        public string factory { get; set; }
        /// <summary>
        /// 生产厂商联系人
        /// </summary>
        public string factoryContact { get; set; }
        /// <summary>
        /// 生产厂商地址
        /// </summary>
        public string factoryAddr { get; set; }
        /// <summary>
        /// 生产厂商电话
        /// </summary>
        public string factoryTel { get; set; }
        /// <summary>
        /// 合同协议号
        /// </summary>
        public string contrNo { get; set; }
        /// <summary>
        /// 签约日期
        /// </summary>
        public string contrDate { get; set; }
        /// <summary>
        /// 发票编号
        /// </summary>
        public string invoiceNo { get; set; }
        /// <summary>
        /// 发票日期
        /// </summary>
        public string invoiceDate { get; set; }
        /// <summary>
        /// 买卖双方之间存在的关系
        /// </summary>
        public string iBabRel { get; set; }
        /// <summary>
        /// 买卖双方关系是否影响进口货物成交价格
        /// </summary>
        public string iPriceEffect { get; set; }
        /// <summary>
        /// 进口货物成交价格相近情况
        /// </summary>
        public string iPriceClose { get; set; }
        /// <summary>
        /// 买方处置或使用货物时是否受到除行政法规规定的限制以及对货物销售地域限制以外的限制
        /// </summary>
        public string iOtherLimited { get; set; }
        /// <summary>
        /// 货物的价格是否受到使货物的成交价格无法确定的条件或因素的影响
        /// </summary>
        public string iOtherEffect { get; set; }
        /// <summary>
        /// 如果上述任一问题的回答为是，请说明限制、条件或因素的内容
        /// </summary>
        public string iNote1 { get; set; }
        /// <summary>
        /// 买方是否应直接或间接支付与进口货物有关并作为货物销售条件的特许权使用费
        /// </summary>
        public string iIsUsefee { get; set; }
        /// <summary>
        /// 卖方是否直接或间接从买方对该货物进口后销售、处置或者使用所得中获得收益
        /// </summary>
        public string iIsProfit { get; set; }
        /// <summary>
        /// 如存在以上特许权使用费和收益的支付，且其金额在进口时不能确定的，请说明
        /// </summary>
        public string iNote2 { get; set; }
        /// <summary>
        /// 币制
        /// </summary>
        public string curr { get; set; }
        /// <summary>
        /// 发票价格单位金额
        /// </summary>
        public string invoicePrice { get; set; }
        /// <summary>
        /// 发票价格总金额
        /// </summary>
        public string invoiceAmount { get; set; }
        /// <summary>
        /// 发票价格备注
        /// </summary>
        public string invoiceNote { get; set; }
        /// <summary>
        /// 间接支付/收取的货款单位金额
        /// </summary>
        public string goodsPrice { get; set; }
        /// <summary>
        /// 间接支付/收取的货款总金额
        /// </summary>
        public string goodsAmount { get; set; }
        /// <summary>
        /// 间接支付/收取的货款备注
        /// </summary>
        public string goodsNote { get; set; }
        /// <summary>
        /// 进口货物除购货佣金以外的佣金和经纪费单位金额
        /// </summary>
        public string iCommissionPrice { get; set; }
        /// <summary>
        /// 进口货物除购货佣金以外的佣金和经纪费总金额
        /// </summary>
        public string iCommissionAmount { get; set; }
        /// <summary>
        /// 进口货物除购货佣金以外的佣金和经纪费备注
        /// </summary>
        public string iCommissionNote { get; set; }
        /// <summary>
        /// 与该进口货物视为一体的容器费用单位金额
        /// </summary>
        public string iContainerPrice { get; set; }
        /// <summary>
        /// 与该进口货物视为一体的容器费用总金额
        /// </summary>
        public string iContainerAmount { get; set; }
        /// <summary>
        /// 与该进口货物视为一体的容器费用备注
        /// </summary>
        public string iContainerNote { get; set; }
        /// <summary>
        /// 进口货物包装材料和包装劳务费用单位金额
        /// </summary>
        public string iPackPrice { get; set; }
        /// <summary>
        /// 进口货物包装材料和包装劳务费用总金额
        /// </summary>
        public string iPackAmount { get; set; }
        /// <summary>
        /// 进口货物包装材料和包装劳务费用备注
        /// </summary>
        public string iPackNote { get; set; }
        /// <summary>
        /// 进口货物包含的材料、部件、零件和类似货物单位金额
        /// </summary>
        public string iPartPrice { get; set; }
        /// <summary>
        /// 进口货物包含的材料、部件、零件和类似货物总金额
        /// </summary>
        public string iPartAmount { get; set; }
        /// <summary>
        /// 进口货物包含的材料、部件、零件和类似货物备注
        /// </summary>
        public string iPartNote { get; set; }
        /// <summary>
        /// 在生产进口货物过程中使用的工具、模具和类似货物单位金额
        /// </summary>
        public string iToolPrice { get; set; }
        /// <summary>
        /// 在生产进口货物过程中使用的工具、模具和类似货物总金额
        /// </summary>
        public string iToolAmount { get; set; }
        /// <summary>
        /// 在生产进口货物过程中使用的工具、模具和类似货物备注
        /// </summary>
        public string iToolNote { get; set; }
        /// <summary>
        /// 在生产进口货物过程中消耗的材料单位金额
        /// </summary>
        public string iLossPrice { get; set; }
        /// <summary>
        /// 在生产进口货物过程中消耗的材料总金额
        /// </summary>
        public string iLossAmount { get; set; }
        /// <summary>
        /// 在生产进口货物过程中消耗的材料备注
        /// </summary>
        public string iLossNote { get; set; }
        /// <summary>
        /// 进口货物在境外进行的为生产进口货物所需的工程设计、技术研发、工艺及制图等相关服务单位金额
        /// </summary>
        public string iDesignPrice { get; set; }
        /// <summary>
        /// 进口货物在境外进行的为生产进口货物所需的工程设计、技术研发、工艺及制图等相关服务总金额
        /// </summary>
        public string iDesignAmount { get; set; }
        /// <summary>
        /// 进口货物在境外进行的为生产进口货物所需的工程设计、技术研发、工艺及制图等相关服务备注
        /// </summary>
        public string iDesignNote { get; set; }
        /// <summary>
        /// 特许权使用费单位金额
        /// </summary>
        public string iUsefeePrice { get; set; }
        /// <summary>
        /// 特许权使用费总金额
        /// </summary>
        public string iUsefeeAmount { get; set; }
        /// <summary>
        /// 特许权使用费备注
        /// </summary>
        public string iUsefeeNote { get; set; }
        /// <summary>
        /// 卖方直接或间接从买方对货物进口后转售、处置或使用所得中获得的收益单位金额
        /// </summary>
        public string iProfitPrice { get; set; }
        /// <summary>
        /// 卖方直接或间接从买方对货物进口后转售、处置或使用所得中获得的收益总金额
        /// </summary>
        public string iProfitAmount { get; set; }
        /// <summary>
        /// 卖方直接或间接从买方对货物进口后转售、处置或使用所得中获得的收益备注
        /// </summary>
        public string iProfitNote { get; set; }
        /// <summary>
        /// 进口货物运输费用单位金额
        /// </summary>
        public string iFeePrice { get; set; }
        /// <summary>
        /// 进口货物运输费用总金额
        /// </summary>
        public string iFeeAmount { get; set; }
        /// <summary>
        /// 进口货物运输费用备注
        /// </summary>
        public string iFeeNote { get; set; }
        /// <summary>
        /// 进口货物运输相关费用单位金额
        /// </summary>
        public string iOtherPrice { get; set; }
        /// <summary>
        /// 进口货物运输相关费用总金额
        /// </summary>
        public string iOtherAmount { get; set; }
        /// <summary>
        /// 进口货物运输相关费用备注
        /// </summary>
        public string iOtherNote { get; set; }
        /// <summary>
        /// 进口货物保险费单位金额
        /// </summary>
        public string iInsurPrice { get; set; }
        /// <summary>
        /// 进口货物保险费总金额
        /// </summary>
        public string iInsurAmount { get; set; }
        /// <summary>
        /// 进口货物保险费备注
        /// </summary>
        public string iInsurNote { get; set; }
        /// <summary>
        /// 出口关税是否已经从申报价格中扣除
        /// </summary>
        public string eIsDutyDel { get; set; }
    }

    public class CheckJsonT_DEC_GOODS_LIMIT
    {
        /// <summary>
        /// 
        /// </summary>
        public string guid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int goodsNo { get; set; }
        /// <summary>
        /// 许可证类别代码
        /// </summary>
        public string licTypeCode { get; set; }
        /// <summary>
        /// 许可证编号
        /// </summary>
        public string licenceNo { get; set; }
        /// <summary>
        /// 许可证核销明细序号
        /// </summary>
        public string licWrtofDetailNo { get; set; }
        /// <summary>
        /// 许可证核销数量
        /// </summary>
        public string licWrtofQty { get; set; }
        /// <summary>
        /// 许可证核销数量单位
        /// </summary>
        public string licWrtofQtyUnit { get; set; }
    }

    public class CheckJsonT_DEC_GOODS_LIMIT_VIN
    {
        /// <summary>
        /// 许可证编号
        /// </summary>
        public string licenceNo { get; set; }
        /// <summary>
        /// 许可证类别代码
        /// </summary>
        public string lictypeCode { get; set; }
        /// <summary>
        /// VIN序号
        /// </summary>
        public string vinNo { get; set; }
        /// <summary>
        /// 提/运单日期 yyyyMMdd 
        /// </summary>
        public string billLadDate { get; set; }
        /// <summary>
        /// 质量保质期
        /// </summary>
        public string qualityQgp { get; set; }
        /// <summary>
        /// 发动机号或电机号
        /// </summary>
        public string motorNo { get; set; }
        /// <summary>
        /// 车辆识别代码（VIN）
        /// </summary>
        public string vinCode { get; set; }
        /// <summary>
        /// 底盘(车架)号
        /// </summary>
        public string chassisNo { get; set; }
        /// <summary>
        /// 发票所列数量
        /// </summary>
        public string invoiceNum { get; set; }
        /// <summary>
        /// 品名（中文名称）
        /// </summary>
        public string prodCnnm { get; set; }
        /// <summary>
        /// 品名（英文名称）
        /// </summary>
        public string prodEnnm { get; set; }
        /// <summary>
        /// 型号（英文）
        /// </summary>
        public string modelEn { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public string pricePerUnit { get; set; }
        /// <summary>
        /// 发票号
        /// </summary>
        public string invoiceNo { get; set; }
    }

    public class CheckJsonLIMIT_VIN_PAIRItem
    {
        /// <summary>
        /// 
        /// </summary>
        public T_DEC_GOODS_LIMIT T_DEC_GOODS_LIMIT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public T_DEC_GOODS_LIMIT_VIN T_DEC_GOODS_LIMIT_VIN { get; set; }
    }

    public class CheckJsonLIST_LIMIT_SUP_LISTItem
    {
        /// <summary>
        /// 
        /// </summary>
        public T_SWGD_FORM_LIST T_SWGD_FORM_LIST { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<T_SWGD_FORM_CLASSIFYSUPItem> T_SWGD_FORM_CLASSIFYSUP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<T_SWGD_FORM_ORIGINALSUPItem> T_SWGD_FORM_ORIGINALSUP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<T_SWGD_FORM_PRICESUPItem> T_SWGD_FORM_PRICESUP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<LIMIT_VIN_PAIRItem> LIMIT_VIN_PAIR { get; set; }
    }

    public class CheckJsonT_SWGD_FORM_CONTAINERItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int containerNo { get; set; }
        /// <summary>
        /// 集装箱号
        /// </summary>
        public string containerId { get; set; }
        /// <summary>
        /// 集装箱规格
        /// </summary>
        public string containerMdStd { get; set; }
        /// <summary>
        /// 商品项号 用半角逗号分隔
        /// </summary>
        public string goodsNo { get; set; }
        /// <summary>
        /// 拼箱标识
        /// </summary>
        public string lclFlag { get; set; }
        /// <summary>
        /// 箱货重量
        /// </summary>
        public string goodsContaWt { get; set; }
        /// <summary>
        /// 自重
        /// </summary>
        public string containerWt { get; set; }
    }

    public class CheckJsonT_SWGD_FORM_CERTIFICATEItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int certificateNo { get; set; }
        /// <summary>
        /// 单证代码
        /// </summary>
        public string docuCode { get; set; }
        /// <summary>
        /// 单证编号
        /// </summary>
        public string certCode { get; set; }
    }

    public class CheckJsonT_DEC_MARK_LOBItem
    {
        /// <summary>
        /// 附件名称
        /// </summary>
        public string attachName { get; set; }
        /// <summary>
        /// 附件类型
        /// </summary>
        public string attachType { get; set; }
        /// <summary>
        /// 附件 计算机无法录入的标记及号码的图案或内容，不超过1MB
        /// </summary>
        public string attachment { get; set; }
    }

    public class CheckJsonT_DEC_REQUEST_CERTItem
    {
        /// <summary>
        /// 申请单证代码
        /// </summary>
        public string appCertCode { get; set; }
        /// <summary>
        /// 申请单证正本数
        /// </summary>
        public string applOri { get; set; }
        /// <summary>
        /// 申请单证副本数
        /// </summary>
        public string applCopyQuan { get; set; }
    }

    public class CheckJsonT_DEC_OTHER_PACKItem
    {
        /// <summary>
        /// 包装件数
        /// </summary>
        public string packQty { get; set; }
        /// <summary>
        /// 包装材料种类
        /// </summary>
        public string packType { get; set; }
    }

    public class CheckJsonT_DEC_COP_LIMITItem
    {
        /// <summary>
        /// 企业资质编号
        /// </summary>
        public string entQualifNo { get; set; }
        /// <summary>
        /// 企业资质类别代码
        /// </summary>
        public string entQualifTypeCode { get; set; }
    }

    public class CheckJsonT_DEC_COP_PROMISEItem
    {
        /// <summary>
        /// 证明/声明材料代码
        /// </summary>
        public string declarationMaterialCode { get; set; }
    }

    public class CheckJsonT_DEC_USERItem
    {
        /// <summary>
        /// 使用单位联系人
        /// </summary>
        public string useOrgPersonCode { get; set; }
        /// <summary>
        /// 使用单位联系电话
        /// </summary>
        public string useOrgPersonTel { get; set; }
    }

    public class CheckJsonT_SWGD_FORM_EDOCItem
    {
        /// <summary>
        /// 文件名、随附单据编号（命名规则是：申报口岸+随附单据类别代码+IM+18位流水号）
        /// </summary>
        public string fileName { get; set; }
        /// <summary>
        /// 随附单证类别
        /// </summary>
        public string edoccode { get; set; }
        /// <summary>
        /// 随附单据格式类型
        /// </summary>
        public string edocfomattype { get; set; }
        /// <summary>
        /// 操作说明（重传原因）
        /// </summary>
        public string opnote { get; set; }
        /// <summary>
        /// 随附单据文件企业名
        /// </summary>
        public string edoccopid { get; set; }
        /// <summary>
        /// 所属单位海关编号
        /// </summary>
        public string edocownercode { get; set; }
        /// <summary>
        /// 签名单位代码
        /// </summary>
        public string signunit { get; set; }
        /// <summary>
        /// 签名时间
        /// </summary>
        public string signtime { get; set; }
        /// <summary>
        /// 所属单位名称
        /// </summary>
        public string edocownername { get; set; }
        /// <summary>
        /// 随附单据文件大小
        /// </summary>
        public string edocSize { get; set; }
    }

    public class CheckJsonT_SWGD_FORM_ECOItem
    {
        /// <summary>
        /// 单据类型
        /// </summary>
        public string certType { get; set; }
        /// <summary>
        /// 报关单商品项号
        /// </summary>
        public string decGNo { get; set; }
        /// <summary>
        /// 单据证书号
        /// </summary>
        public string ecoCertNo { get; set; }
        /// <summary>
        /// 原产地证书单证项号
        /// </summary>
        public string ecoGNo { get; set; }
        /// <summary>
        /// 扩展字段
        /// </summary>
        public string extendFiled { get; set; }
    }

    public class CheckJsonT_SWGD_SDDTAX_HEAD
    {
        /// <summary>
        /// EDI单据编号
        /// </summary>
        public string ediNo { get; set; }
        /// <summary>
        /// 文件名称
        /// </summary>
        public string fileName { get; set; }
        /// <summary>
        /// 与录入号
        /// </summary>
        public string seqNo { get; set; }
        /// <summary>
        /// 进出口标志
        /// </summary>
        public string iEFlag { get; set; }
        /// <summary>
        /// 申报口岸
        /// </summary>
        public string declPort { get; set; }
        /// <summary>
        /// 预计申报日期
        /// </summary>
        public string dDate { get; set; }
        /// <summary>
        /// 经营单位编号
        /// </summary>
        public string tradeCo { get; set; }
        /// <summary>
        /// 经营单位名称
        /// </summary>
        public string tradeName { get; set; }
        /// <summary>
        /// 内销比率
        /// </summary>
        public string inRatio { get; set; }
        /// <summary>
        /// 贸易方式
        /// </summary>
        public string tradeMode { get; set; }
        /// <summary>
        /// 征免性质分类
        /// </summary>
        public string cutMode { get; set; }
        /// <summary>
        /// 成交方式
        /// </summary>
        public string transMode { get; set; }
        /// <summary>
        /// 运费标记
        /// </summary>
        public string feeMark { get; set; }
        /// <summary>
        /// 运费币制
        /// </summary>
        public string feeCurr { get; set; }
        /// <summary>
        /// 运费／率
        /// </summary>
        public string feeRate { get; set; }
        /// <summary>
        /// 保险费标记
        /// </summary>
        public string insurMark { get; set; }
        /// <summary>
        /// 保险费币制
        /// </summary>
        public string insurCurr { get; set; }
        /// <summary>
        /// 保险费／率
        /// </summary>
        public string insurRate { get; set; }
        /// <summary>
        /// 杂费标记
        /// </summary>
        public string otherMark { get; set; }
        /// <summary>
        /// 杂费币制
        /// </summary>
        public string otherCurr { get; set; }
        /// <summary>
        /// 杂费／率
        /// </summary>
        public string otherRate { get; set; }
        /// <summary>
        /// 备案号
        /// </summary>
        public string manualNo { get; set; }
        /// <summary>
        /// 经营单位统一代码
        /// </summary>
        public string tradeCoScc { get; set; }
        /// <summary>
        /// 毛重
        /// </summary>
        public string grossWt { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string noteS { get; set; }
        /// <summary>
        /// 法律责任
        /// </summary>
        public string legalLiability { get; set; }
        /// <summary>
        /// 数字签名信息
        /// </summary>
        public string sign { get; set; }
        /// <summary>
        /// 签名消息号
        /// </summary>
        public string messId { get; set; }
        /// <summary>
        /// 签名证书号
        /// </summary>
        public string certSeqNo { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string status { get; set; }
    }

    public class CheckJsonT_SWGD_SDDTAX_LISTItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int gNo { get; set; }
        /// <summary>
        /// 与表T_SWGD_FORM_LIST中的字段guid对应
        /// </summary>
        public string formListGuid { get; set; }
        /// <summary>
        /// 商品编号
        /// </summary>
        public string codeTs { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string gName { get; set; }
        /// <summary>
        /// 产销国
        /// </summary>
        public string originCountry { get; set; }
        /// <summary>
        /// 协定编号
        /// </summary>
        public string agreementId { get; set; }
        /// <summary>
        /// 第一数量
        /// </summary>
        public string qty1 { get; set; }
        /// <summary>
        /// 第一计量单位
        /// </summary>
        public string unit1 { get; set; }
        /// <summary>
        /// 第二数量
        /// </summary>
        public string qty2 { get; set; }
        /// <summary>
        /// 第二计量单位
        /// </summary>
        public string unit2 { get; set; }
        /// <summary>
        /// 成交币制
        /// </summary>
        public string tradeCurr { get; set; }
        /// <summary>
        /// 申报单价
        /// </summary>
        public string declPrice { get; set; }
        /// <summary>
        /// 申报总价
        /// </summary>
        public string declTotal { get; set; }
        /// <summary>
        /// 征减免税方式
        /// </summary>
        public string dutyMode { get; set; }
        /// <summary>
        /// 反倾销涉案
        /// </summary>
        public string antidumping { get; set; }
        /// <summary>
        /// 反补贴涉案
        /// </summary>
        public string antisubsidy { get; set; }
        /// <summary>
        /// 特案完税价格
        /// </summary>
        public string dutyValue { get; set; }
        /// <summary>
        /// 关税从价税率
        /// </summary>
        public string dutyRate { get; set; }
        /// <summary>
        /// 关税从量税率
        /// </summary>
        public string qtyDutyRate { get; set; }
        /// <summary>
        /// 消费税从价税率
        /// </summary>
        public string regRate { get; set; }
        /// <summary>
        /// 消费税从量税率
        /// </summary>
        public string qtyRegRate { get; set; }
        /// <summary>
        /// 增值税率
        /// </summary>
        public string taxRate { get; set; }
        /// <summary>
        /// 反倾销税率
        /// </summary>
        public string antidumpingRate { get; set; }
        /// <summary>
        /// 反补贴税率
        /// </summary>
        public string antisubsidyRate { get; set; }
        /// <summary>
        /// 废弃基金税率
        /// </summary>
        public string trashfundRate { get; set; }
    }

    public class CheckJsonT_SWGD_SDDTAX_DETAILSItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int gNo { get; set; }
        /// <summary>
        /// 与表T_SWGD_FORM_LIST中的字段guid对应
        /// </summary>
        public string formListGuid { get; set; }
        /// <summary>
        /// 税种
        /// </summary>
        public string taxType { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public string realTax { get; set; }
    }

    public class CheckJsonDataJsonData
    {
        /// <summary>
        /// 
        /// </summary>
        public CheckJsonT_SWGD_FORM_HEAD CheckJsonT_SWGD_FORM_HEAD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<CheckJsonLIST_LIMIT_SUP_LISTItem> CheckJsonLIST_LIMIT_SUP_LIST { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<CheckJsonT_SWGD_FORM_CONTAINERItem> CheckJsonT_SWGD_FORM_CONTAINER { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<CheckJsonT_SWGD_FORM_CERTIFICATEItem> CheckJsonT_SWGD_FORM_CERTIFICATE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<CheckJsonT_DEC_MARK_LOBItem> CheckJsonT_DEC_MARK_LOB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<CheckJsonT_DEC_REQUEST_CERTItem> CheckJsonT_DEC_REQUEST_CERT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<CheckJsonT_DEC_OTHER_PACKItem> CheckJsonT_DEC_OTHER_PACK { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<CheckJsonT_DEC_COP_LIMITItem> CheckJsonT_DEC_COP_LIMIT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<CheckJsonT_DEC_COP_PROMISEItem> CheckJsonT_DEC_COP_PROMISE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<CheckJsonT_DEC_USERItem> CheckJsonT_DEC_USER { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<CheckJsonT_SWGD_FORM_EDOCItem> CheckJsonT_SWGD_FORM_EDOC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<CheckJsonT_SWGD_FORM_ECOItem> CheckJsonT_SWGD_FORM_ECO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public CheckJsonT_SWGD_SDDTAX_HEAD CheckJsonT_SWGD_SDDTAX_HEAD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<CheckJsonT_SWGD_SDDTAX_LISTItem> CheckJsonT_SWGD_SDDTAX_LIST { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<CheckJsonT_SWGD_SDDTAX_DETAILSItem> CheckJsonT_SWGD_SDDTAX_DETAILS { get; set; }
    }

    public class CheckJsonDataJsonRoot
    {
        /// <summary>
        /// 
        /// </summary>
        public CheckJsonDataJsonData CheckJsonDataJsondata { get; set; }
    }
}