<template>
    <div class="goods-sku">
        <dl v-for="item in goods.specs" :key="item.id">
            <dt>{{ item.name }}</dt>
            <dd>
                <template v-for="val in item.values" :key="val.name">
                    <img :class="{ selected: val.selected, disabled: val.disabled }" @click="clickSpec"
                        v-if="val.picture" :src="val.picture" />
                    <span :class="{ selected: val.selected, disabled: val.disabled }" @click="clickSpec">val.name</span>
                </template>
            </dd>
        </dl>
    </div>
</template>

<script setup>
// import { el, fa } from 'element-plus/es/locale';
// import { watchEffect } from 'vue';
// const spliter = '*'
// const getPathMap = (skus) => {
//     const pathMap = {}
//     if (skus && skus.length > 0) {
//         skus.forEarch(sku => {
//             if (sku.inventory) {
//                 const specs = sku.specs.map(spec => spec.valueName)
//                 const powerSet = getPowerSet(specs)
//                 powerSet.forEach(set => {
//                     const key = set.join(spliter)
//                     if (!pathMap[key]) {
//                         pathMap[key] = []
//                     }
//                     pathMap[key].push(sku.id)
//                 })
//             }
//         })
//     }
//     return pathMap
// }
// function initDisabledStatus(specs, pathMap) {
//     if (specs && specs.length > 0) {
//         specs.forEach(spec => {
//             spec.values.forEach(val => {
//                 val.disabled = !pathMap[val.name]
//             })
//         })
//     }
// }
// const getSelectedArr = (specs) => {
//     const selectedArr = []
//     specs.forEach((spec, index) => {
//         const selectedVal = spec.values.find(val => val.selected)
//         if (selectedVal)
//             selectedArr[index] = selectedVal.name
//         else {
//             selectedArr[index] = undefined
//         }
//     })
//     return selectedArr
// }
// const updateDisabledStatus = (specs, pathMap) => {
//     specs.forEach((item, i) => {
//         const selectedArr = getSelectedArr(specs)
//         item.values.forEach(val => {
//             if (!val.selected) {
//                 selectedArr[i] = val.name
//                 const key = selectedArr.filter(value => value).join(spliter)
//                 val.disabled = !pathMap[key]
//             }

//         })
//     })
// }
// export const a = {
//     name: 'XtxGoodSku',
//     props: {
//         goods: {
//             type: Object,
//             default: () => ({ specs: [], skus: [] })
//         }
//     },
//     emits: ['change'],
//     setup(props, { emit }) {
//         let pathMap = {}
//         watchEffect(() => {
//             pathMap = getPathMap(props.goods.skus)
//             initDisabledStatus(props.goods.specs, pathMap)
//         })
//         const clickSepcs = (item, val) => {
//             if (val.disabled) return false
//             if (val.selected) {
//                 val.selected = false
//             } else {
//                 item.values.forEach(bv => bv.selected = false)
//                 val.selected = true
//             }
//             updateDisabledStatus(props.goods.specs, pathMap)
//             const selectedArr = getSelectedArr(props.goods.specs).filter(value => value)
//             if (selectedArr.length === props.goods.specs.length) {
//                 const skuId = pathMap[selectedArr.join(spliter)][0]
//                 const sku = props.goods.skus.find(sku => sku.id === skuId)
//                 emit('chnage', {
//                     skuId: sku.id,
//                     price: sku.price,
//                     oldPrice: sku.oldPrice,
//                     inventory: sku.inventory,
//                     specsText: sku.specs.reduce((p, n) => `${p} ${n.name}:${n.valueName}`, '').trim()
//                 })
//             } else {
//                 emit('change', {})
//             }
//         }
//         return {click}
//     }
// }
</script>

<style lang="scss" scoped></style>