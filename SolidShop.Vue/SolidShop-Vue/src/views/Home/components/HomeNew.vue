<template>
    <HomePanel title="新鲜好物" subtitle="新鲜出炉 品质靠谱">
        <ul class="goods-list">
            <li v-for="item in newList" :key="item.id">
                <RouterLink to="/">
                    <img v-img-lazy="item.image" :src="item.image" alt="">
                    <p class="name">{{ item.name }}</p>
                    <p class="price">{{ item.price }}</p>
                </RouterLink>
            </li>
        </ul>
    </HomePanel>
</template>

<script setup>
import HomePanel from './HomePanel.vue'
import { ref, onMounted } from 'vue'
import { findNewAPI } from '@/apis/home'
const newList = ref([])
const getNewList = async () => {
    const res = await findNewAPI()
    console.log(res)
    newList.value = res.map(n => {
        n.image = "src/assets/images/" + n.image
        return n
    })

}

onMounted(() => {
    getNewList()
})
</script>

<style lang="scss" scoped>
.goods-list {
    display: flex;
    justify-content: space-between;
    height: 406px;

    li {
        list-style: none;
        width: 306px;
        height: 406px;

        &:hover {
            transform: translateY(-5px);
            transition: all 0.3s;
        }
    }
}
</style>