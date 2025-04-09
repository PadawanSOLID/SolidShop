<template>
    <div>

    </div>
</template>

<script setup>

</script>

<style lang="scss" scoped>

.goods-tab{
    min-height: 600px;
    background: #fff;
}
.goods-warn{
    min-height: 600px;
    background: #fff;
    margin-top: 20px;
}

.goods-footer{
    display: flex;margin-top: 20px;
    .good-article{
        width: 940px;
        margin-right: 20px;
    }
    .goods-aside{
        width: 280px;min-height: 1000px;
    }
}
.goods-tabs{
    min-height: 600px;
    background: #fff;
}
.label{
    width: 60px;
    color: #999;
    padding-left: 10px;
}
.g-name {
    font-size: 22px;
}

.g-desc {
    color: #999;
    margin-top: 10px;
}

.g-price {
    margin-top: 10px;

    span {
        &::before {
            content: "￥";
            font-size: 14px;
        }
    }
}

.g-service {
    background: #f5f5f5;
    width: 500px;
    padding: 20px 10px 0 10px;
    margin-top: 10px;

    dl {
        padding-bottom: 20px;
        display: flex;
        align-items: center;
    }
}

.dt {
    width: 100px;
    color: #999;
}

.dd {
    flex: 1;
    color: #666;
}

.btn {
    margin-top: 20px;
}

.bread-container {
    padding: 25px 0;
}
</style>