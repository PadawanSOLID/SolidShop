<script setup>
import { useCounterStore } from './stores/counter';

const counterStore = useCounterStore();
const add=()=>{
    counterStore.increment(5);
}

</script>

<template>
    <button @click="add">{{ counterStore.count }}</button>
</template>

<style scoped></style>
