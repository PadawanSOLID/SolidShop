<template>
    <div class="container">
        <div class="bread-container">
            <el-breadcrumb separator=">">
                <el-breadcrumb-item :to="{ path: '/' }">首页</el-breadcrumb-item>
                <el-breadcrumb-item :to="{ path: `/category/${categoryData.parentId}` }">{{ categoryData.parentName
                }}</el-breadcrumb-item>
                <el-breadcrumb-item>{{ categoryData.name }}</el-breadcrumb-item>
            </el-breadcrumb>
        </div>
        <div class="sub-container">
            <el-tabs v-model="reqData.sortField" @tab-change="tabChange">
                <el-tab-pane label="最新商品" name="publishTime"></el-tab-pane>
                <el-tab-pane label="最高人气" name="orderNum"></el-tab-pane>
                <el-tab-pane label="评论最多" name="evaludateNum"></el-tab-pane>
            </el-tabs>
            <div class="body" v-infinite-scroll="load" :infinite-scroll-disabled="disabled">
                <GoodsItem v-for="good in goodList" :good :key="good.id" />
            </div>
        </div>
    </div>
</template>

<script setup>
import { getCategoryFilterAPI, getSubCategoryAPI } from '@/apis/category';
import { onMounted, ref } from 'vue';
import { useRoute } from 'vue-router';
import GoodsItem from '../Home/components/GoodsItem.vue';
const disabled = ref(false)
const route = useRoute()
const goodList = ref([])
const reqData = ref({
    categoryId: route.params.id,
    page: 1,
    pageSize: 10,
    sortField: 'publishTime',
})
const getGoodList = async () => {
    const res = await getSubCategoryAPI(reqData.value)
    goodList.value = res
}
onMounted(() => {
    getGoodList()
})
const categoryData = ref({})

const getCategoryData = async () => {
    const res = await getCategoryFilterAPI(route.params.id)
    categoryData.value = res
}
onMounted(() => getCategoryData())
const tabChange = () => {
    console.log('tab切换了', reqData.value.sortField)
    getGoodList()
}
const load=async()=>{
    reqData.value.page ++
    const res=await getSubCategoryAPI(reqData.value)    
   
    goodList.value= [...goodList.value,...res]
    if(res.length===0){
        disabled.value=true
        
    }
}
</script>

<style lang="scss" scoped>
.body {
    display: flex;
    width: 1200px;
    flex-wrap: wrap;
}

.bread-container {
    padding: 25px 0;
    color: #666;
    display: block;
    width: 220px;
    margin-right: 20px;
    padding: 20px 30px;
    text-align: center;

    img {
        width: 160px;
        height: 160px;
    }

    p {
        padding-top: 10px;
    }

    .name {
        font-size: 16px;
    }

    .desc {
        color: #999;
        height: 29px;
    }

    .price {
        color: $priceColor;
        font-size: 20px;
    }
}



.pagination-container {
    margin-top: 20px;
    display: flex;
    justify-content: center;
}
</style>