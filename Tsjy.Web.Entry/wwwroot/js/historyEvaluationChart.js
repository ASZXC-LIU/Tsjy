window.historyEvaluationChart = (() => {
    const charts = new Map();

    function render(canvasId, labels, uploadData, approvedData, rejectedData) {
        const el = document.getElementById(canvasId);
        if (!el) return;

        // 重绘前销毁旧图
        const old = charts.get(canvasId);
        if (old) old.destroy();

        const ctx = el.getContext('2d');
        const chart = new Chart(ctx, {
            type: 'line',
            data: {
                labels,
                datasets: [
                    { label: '提交/上传', data: uploadData, tension: 0.2 },
                    { label: '通过', data: approvedData, tension: 0.2 },
                    { label: '驳回', data: rejectedData, tension: 0.2 }
                ]
            },
            options: {
                responsive: true,
                interaction: { mode: 'index', intersect: false },
                plugins: {
                    legend: { position: 'top' }
                },
                scales: {
                    y: { beginAtZero: true }
                }
            }
        });

        charts.set(canvasId, chart);
    }

    return { render };
})();
